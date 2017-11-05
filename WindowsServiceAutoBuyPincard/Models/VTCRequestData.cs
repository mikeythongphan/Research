using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace WindowsServiceAutoBuyPincard.Models
{
    [XmlRoot("RequestData")]
    public class RequestData
    {
        public RequestData(string xmlRequest)
        {
            var s = new XmlSerializer(typeof(RequestData));
            TextReader t = new StringReader(xmlRequest);
            var r = (RequestData)s.Deserialize(t);

            Account = r.Account;
            Amount = r.Amount;
            DataSign = r.DataSign;
            OrgTransID = r.OrgTransID;
            Quantity = r.Quantity;
            ServiceCode = r.ServiceCode;
            TransDate = r.TransDate;
        }

        public RequestData(string account, string amount, int quantity, string serviceCode, string orgtranID,
                           string transDate, string dataSign)
        {
            Account = account;
            Amount = amount;
            Quantity = quantity;
            ServiceCode = serviceCode;
            OrgTransID = orgtranID;
            TransDate = transDate;
            DataSign = dataSign;
        }

        public RequestData()
        {
        }

        [XmlElement("ServiceCode")]
        public string ServiceCode { get; set; }

        [XmlElement("Account")]
        public string Account { get; set; }

        [XmlElement("Amount")]
        public string Amount { get; set; }

        [XmlElement("Quantity")]
        public int Quantity { get; set; }

        [XmlElement("TransDate")]
        public string TransDate { get; set; }

        [XmlElement("OrgTransID")]
        public string OrgTransID { get; set; }

        [XmlElement("DataSign")]
        public string DataSign { get; set; }

        public void setTopup()
        {

        }

        public string ToXmlString()
        {
            var s = new XmlSerializer(typeof(RequestData));
            TextWriter w = new StringWriter();
            s.Serialize(w, this);
            return w.ToString();
        }
    }
}
