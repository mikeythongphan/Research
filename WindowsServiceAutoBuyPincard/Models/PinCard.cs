using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using ManagePincards.UPGControlService;

namespace WindowsServiceAutoBuyPincard.Models
{
    public partial class PinCard
    {
        public int FKServiceID { get; set; }
        public int FKPincardCostID { get; set; }
        public int FKConsolidatorID { get; set; }
        public string ServiceName { get; set; }
        static PinCardEntities db = new PinCardEntities();
        public static bool GetExistPincode(string pincode)
        {
            // Hash Code Pincode To MD5
            string pinCodeMD5 = CommonClass.StringValidator.GetMD5String(pincode);
            var objPincard = db.PinCards.FirstOrDefault(p => p.PinCode == pinCodeMD5);
            if (objPincard != null)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Gets the pincard nominal ID.
        /// </summary>
        /// <param name="pincardCostID">The pincard cost ID.</param>
        /// <param name="serviceID">The service ID.</param>
        /// <param name="consolidatorID">The consolidator ID.</param>
        /// <returns></returns>
        public static Models.PincardNominal GetPincardNominal(int pincardCostID, int serviceID, int consolidatorID)
        {
            int pincardNominalID = 0;
            var objServiceConsolidator =
                db.ServiceConsolidators.FirstOrDefault(s => s.FK_ServiceID == serviceID && s.FK_ConsolidatorID == consolidatorID);
            if (objServiceConsolidator == null)
                CommonClass.MessageBox.Show("Dịch vụ của Consolidator chưa có mệnh giá này. Bạn vui lòng định nghĩa ở trang --CK THEO MỆNH GIÁ-- trước khi thêm mã thẻ");
            var objPincardCost = db.PincardCosts.FirstOrDefault(p => p.PincardCostID == pincardCostID);
            var objPincardNominal =
                db.PincardNominals.FirstOrDefault(
                    p =>
                    p.FK_PincardCostID == objPincardCost.PincardCostID &&
                    p.FK_ServiceConsolidatorID == objServiceConsolidator.ServiceConsolidatorID);

            return objPincardNominal;
        }
        /// <summary>
        /// Converts the expire date to datetime.
        /// </summary>
        /// <param name="expdate">The expdate.</param>
        /// <returns>Expire date</returns>
        public static string ConvertExpireDateToDatetime(DateTime? expdate)
        {
            string year = expdate.Value.Year.ToString();
            string month = expdate.Value.Month.ToString();
            string day = expdate.Value.Day.ToString();

            string strDate = string.Format("{0}-{1}-{2}", year, month, day);
            return strDate;
        }
        /// <summary>
        /// Creates the pin cards.
        /// </summary>
        /// <param name="productionID">The production ID.</param>
        /// <param name="objPinCard">The obj pin card.</param>
        /// <param name="pincardCost">The pincard cost.</param>
        /// <returns></returns>
        public static bool CreatePinCards(int productionID, string pinCode, string serialNumber, DateTime? _expireDate, string pincardCost)
        {
            bool isSuccess = false;
            var service = new UPGControlService(ConfigurationManager.AppSettings["upgService"]);
            string inputXml = string.Empty;
            string expireDate = ConvertExpireDateToDatetime(_expireDate);
            inputXml = "<Root><Production ID='" + productionID + "'><Card><PinCode>" + pinCode + "</PinCode><Serial>" + serialNumber + "</Serial><ExpireDate>" + expireDate + "</ExpireDate><CardInfo><root><purchase>" + pincardCost + "</purchase></root></CardInfo></Card> </Production></Root>";
            ReturnMessage message = service.CreatePinCards(ConfigurationManager.AppSettings["UPGUser"], ConfigurationManager.AppSettings["UPGPass"], inputXml);
            if (message != null)
            {
                if (message.Error == 0 && message.SetOfData.Tables[0].Rows.Count > 0)
                    isSuccess = true;
            }
            return isSuccess;
        }
        /// <summary>
        /// Calculates the average commission.
        /// </summary>
        /// <returns></returns>
        public static double CalculateAverageCommission()
        {
            double averageCommission = 0;

            double sumCommission = Convert.ToDouble(db.PinCards.Sum(p => p.CurrentCommission));
            if (sumCommission > 0)
            {
                averageCommission = Math.Round(sumCommission / db.PinCards.Count(), 1);
            }

            return averageCommission;
        }
    }
}
