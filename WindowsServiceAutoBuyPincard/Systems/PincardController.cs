using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using ManagePincards.UPGControlService;

namespace WindowsServiceAutoBuyPincard.Systems
{
    public class PincardController
    {
        /// <summary>
        /// Gets the consolidator cost no.
        /// </summary>
        /// <param name="cardProductionID">The card production ID.</param>
        /// <returns>Logich cost code by cost, service and consolidator</returns>
        public string GetPincardNominalCode(int cardProductionID, int consolidatorID)
        {
            var db = new Models.PinCardEntities();
            string consolidatorCostNo = string.Empty;
            var objPincardNominal = db.PincardNominals.FirstOrDefault(p => p.UPGCardProductionID == cardProductionID && p.ServiceConsolidator.FK_ConsolidatorID == consolidatorID);
            if (objPincardNominal != null) consolidatorCostNo = objPincardNominal.LogichCostCode;
            return consolidatorCostNo;
        }
        /// <summary>
        /// GetPincardNominalCode
        /// </summary>
        /// <param name="cardProductionID"></param>
        /// <param name="serviceID"></param>
        /// <returns></returns>
        public static string GetPincardNominalCode(int cardProductionID, string serviceID)
        {
            var db = new Models.PinCardEntities();
            string consolidatorCostNo = string.Empty;
            var objPincardNominal = db.PincardNominals.FirstOrDefault(p => p.UPGCardProductionID == cardProductionID && p.ServiceConsolidator.FK_ServiceID.ToString().Equals(serviceID));
            if (objPincardNominal != null) consolidatorCostNo = objPincardNominal.LogichCostCode;
            return consolidatorCostNo;
        }
        /// <summary>
        /// CreatePinCards
        /// </summary>
        /// <param name="productionID"></param>
        /// <param name="objPinCard"></param>
        /// <param name="pincardCost"></param>
        /// <returns></returns>
        public bool CreatePinCards(int productionID, Models.PinCard objPinCard, string pincardCost)
        {
            bool isSuccess = false;
            var service = new UPGControlService(ConfigurationManager.AppSettings["upgService"]);
            string inputXml = string.Empty;
            inputXml = "<Root><Production ID='" + productionID + "'><Card><PinCode>" + objPinCard.PinCode + "</PinCode><Serial>" + objPinCard.SerialNumber + "</Serial><ExpireDate>" + objPinCard.ExpireDate.Value.ToString("yyyy-MM-dd") + "</ExpireDate><CardInfo><root><purchase>" + pincardCost + "</purchase></root></CardInfo></Card> </Production></Root>";
            ReturnMessage message = service.CreatePinCards(ConfigurationManager.AppSettings["UPGUser"], ConfigurationManager.AppSettings["UPGPass"], inputXml);
            if (message != null)
            {
                if (message.Error == 0 && message.SetOfData.Tables[0].Rows.Count > 0)
                    isSuccess = true;
            }
            return isSuccess;
        }
        /// <summary>
        /// GetAvailablePincards
        /// </summary>
        /// <returns></returns>
        public static List<InventoryPinCode> GetAvailablePincards()
        {
            var service = new UPGControlService(ConfigurationManager.AppSettings["upgService"]);
            ReturnMessage objReturnMessage = service.GetAvailablePinCards(ConfigurationManager.AppSettings["UPGUser"], ConfigurationManager.AppSettings["UPGPass"]);
            DataSet dataSet = objReturnMessage.SetOfData;
            var inventoryList = new List<InventoryPinCode>();
            if (dataSet != null)
            {
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                {
                    var objInventoryPinCode = new InventoryPinCode();
                    objInventoryPinCode.ProviderID = dataRow["ProviderID"].ToString();
                    objInventoryPinCode.ServiceID = dataRow["ServiceID"].ToString();
                    objInventoryPinCode.CardProductionID = dataRow["CardProductionID"].ToString();
                    objInventoryPinCode.ServiceName = dataRow["ServiceName"].ToString();
                    objInventoryPinCode.CardsCount = Convert.ToDouble(dataRow["CardsCount"].ToString());
                    objInventoryPinCode.CardProductionCost = dataRow["CardProductionCost"].ToString();
                    objInventoryPinCode.CardNominalName = dataRow["CardNominalName"].ToString();

                    objInventoryPinCode.ConsolidatorCostNo =
                        GetPincardNominalCode(Convert.ToInt32(objInventoryPinCode.CardProductionID), objInventoryPinCode.ServiceID);
                    inventoryList.Add(objInventoryPinCode);
                }
            }
            return inventoryList.OrderBy(i => i.CardsCount).ToList();
        }
        /// <summary>
        /// GetAvailablePinCardsByMinCardsCount
        /// </summary>
        /// <param name="minCardsCount"></param>
        /// <returns></returns>
        public List<InventoryPinCode> GetAvailablePinCardsByMinCardsCount(double minCardsCount)
        {
            var inventoryPinCode = GetAvailablePincards();
            return inventoryPinCode.Where(i => i.CardsCount < minCardsCount).ToList();
        }
        /// <summary>
        /// GetAvailablePinCardsByMinCardsCountAndCardProductionID
        /// </summary>
        /// <param name="minCardsCount"></param>
        /// <param name="cardProductionID"></param>
        /// <returns></returns>
        public InventoryPinCode GetAvailablePinCardsByMinCardsCountAndCardProductionID(double? minCardsCount, string cardProductionID)
        {
            var inventoryPinCode = GetAvailablePincards();
            foreach (var pinCode in inventoryPinCode)
            {
                pinCode.NumberNeedBuy = Convert.ToInt32(minCardsCount - pinCode.CardsCount);
            }
            return
                inventoryPinCode.FirstOrDefault(
                    i => i.CardsCount < minCardsCount && i.CardProductionID == cardProductionID);
        }
        /// <summary>
        /// GetConsolidatorNo
        /// </summary>
        /// <param name="consolidatorID"></param>
        /// <returns></returns>
        public string GetConsolidatorNo(int consolidatorID)
        {
            using (var db = new Models.PinCardEntities())
            {
                Models.Consolidator pn = db.Consolidators.FirstOrDefault(p => p.ConsolidatorID == consolidatorID);
                if (pn != null)
                {
                    return pn.ConsolidatorNo;
                }
                return string.Empty;
            }
        }
    }
}
