using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using ManagePincards.UPGControlService;

namespace WindowsServiceAutoBuyPincard.Systems
{
    public class InventoryPinCodeController
    {
        public List<InventoryPinCode> GetInventoryPinCode()
        {
            Models.PinCardEntities db = new Models.PinCardEntities();
            var upgService = new UPGControlService(ConfigurationSettings.AppSettings["upgService"].ToString());
            string userName = PincardSecurity.Decrypt(
                ConfigurationSettings.AppSettings["userName"].ToString(),
                ConfigurationSettings.AppSettings["keyPincode"].ToString());
            string passWord = PincardSecurity.Decrypt(
                ConfigurationSettings.AppSettings["passWord"].ToString(),
                ConfigurationSettings.AppSettings["keyPincode"].ToString());
            ReturnMessage objReturnMessage = upgService.GetAvailablePinCards(userName, passWord);
            DataSet dataSet = objReturnMessage.SetOfData;
            var inventoryList = new List<InventoryPinCode>();
            var inventoryListResult = new List<InventoryPinCode>();

            foreach (DataRow dataRow in dataSet.Tables[0].Rows)
            {
                var objInventoryPinCode = new InventoryPinCode();
                objInventoryPinCode.ProviderID = dataRow["ProviderID"].ToString();
                objInventoryPinCode.ServiceID = dataRow["ServiceID"].ToString();
                objInventoryPinCode.CardProductionID = dataRow["CardProductionID"].ToString();
                objInventoryPinCode.ServiceName = dataRow["ServiceName"].ToString();
                int cardProductionID = Convert.ToInt32(objInventoryPinCode.CardProductionID);
                var minInventory = db.MinInventorys.FirstOrDefault(m => m.UPGCardProductionID == cardProductionID);

                if (minInventory != null)
                {
                    objInventoryPinCode.MinCardsCount = minInventory.MinInventoryQuantity;
                }
                objInventoryPinCode.CardsCount = Convert.ToDouble(dataRow["CardsCount"].ToString());
                objInventoryPinCode.CardProductionCost = dataRow["CardProductionCost"].ToString();
                objInventoryPinCode.Cost = Convert.ToDouble(objInventoryPinCode.CardProductionCost);
                objInventoryPinCode.Amount = objInventoryPinCode.CardsCount * Convert.ToDouble(objInventoryPinCode.CardProductionCost);
                objInventoryPinCode.CardNominalName = dataRow["CardNominalName"].ToString();

                inventoryList.Add(objInventoryPinCode);
            }

            foreach (var objMinInventory in db.MinInventorys)
            {
                string upgCardProductionID = Convert.ToString(objMinInventory.UPGCardProductionID);
                InventoryPinCode objInventoryPinCode =
                    inventoryList.FirstOrDefault(i => i.CardProductionID == upgCardProductionID);
                if (objInventoryPinCode != null)
                {
                    objInventoryPinCode.NumberNeedBuy =
                        Convert.ToInt32((objMinInventory.MinInventoryQuantity -
                                   Convert.ToDouble(objInventoryPinCode.CardsCount)));
                    objInventoryPinCode.ServiceName = objMinInventory.Service.ServiceName;
                    objInventoryPinCode.ServiceID = objMinInventory.FK_ServiceID.ToString();
                    inventoryListResult.Add(objInventoryPinCode);
                }
                else// Trường hợp UPG không trả về các mã thẻ hết kho(cardCount = 0)
                {
                    objInventoryPinCode = new InventoryPinCode();
                    objInventoryPinCode.CardsCount = 0;
                    objInventoryPinCode.MinCardsCount = objMinInventory.MinInventoryQuantity;
                    objInventoryPinCode.NumberNeedBuy = Convert.ToInt32(objMinInventory.MinInventoryQuantity);
                    objInventoryPinCode.CardProductionID = objMinInventory.UPGCardProductionID.ToString();
                    string[] serviceName = objMinInventory.Service.ServiceName.Split(' ');
                    objInventoryPinCode.CardNominalName = string.Format("{0} {1}", serviceName[0],
                                                                        objMinInventory.PincardCost.PincardCostName);

                    objInventoryPinCode.ServiceName = objMinInventory.Service.ServiceName;
                    objInventoryPinCode.CardProductionCost = objMinInventory.PincardCost.Cost.ToString();
                    objInventoryPinCode.Cost = Convert.ToDouble(objInventoryPinCode.CardProductionCost);
                    // Thom: set ServiceId, ProviderID
                    objInventoryPinCode.ServiceID = objMinInventory.FK_ServiceID.ToString();
                    objInventoryPinCode.ProviderID = objMinInventory.Service.FK_ProviderID.ToString();
                    inventoryListResult.Add(objInventoryPinCode);

                }
            }

            return inventoryListResult.OrderBy(i => i.CardsCount).ToList();
        }
    }
}
