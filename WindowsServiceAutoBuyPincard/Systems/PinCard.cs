using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Xml;

namespace WindowsServiceAutoBuyPincard.Systems
{
    public class PinCardListFactory
    {
        public static PinCardList getAllPinCardAvailable(PinCardListSource source)
        {
            switch (source)
            {
                case PinCardListSource.UPG:
                    return new PinCardListUPG();
            }
            return null;
        }
    }
    public enum PinCardListSource
    {
        UPG = 1,
        DATABASE = 2
    }
    public class PinCardListUPG : PinCardList
    {
        public PinCardListUPG()
        {
            fromUPG();
        }
        public void fromUPG()
        {
            fromXML(UPGRequest.getAvailablePinCard());
        }
    }
    public class PinCardList : List<PinCard>
    {
        public int CardGroupSum { get; set; }
        public decimal CardGroupCost { get; set; }
        public void fromXML(string xml)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xml);
                XmlElement xmlRoot = xmlDoc.DocumentElement;
                var nodeList = xmlRoot.GetElementsByTagName("Table");
                this.CardGroupSum = 0;
                this.CardGroupCost = 0;
                for (int i = 0; i < nodeList.Count; i++)
                {
                    PinCard pincard = new PinCard(nodeList.Item(i));
                    this.Add(pincard);
                    this.CardGroupSum = this.CardGroupSum + pincard.CardsCount;
                    this.CardGroupCost = this.CardGroupCost + (pincard.CardProductionCost * pincard.CardsCount);
                }
            }
            catch (Exception ex)
            {
                //Tools.Logger(ex.Message, "PincardList", "FromXML");
            }
        }
    }
    public class PinCard
    {
        public int CardsCount { get; set; }
        public int CardProductionID { get; set; }
        public int CardNominalID { get; set; }
        public decimal CardProductionCost { get; set; }
        public int CardProductionCount { get; set; }
        public DateTime CardProductionDate { get; set; }
        public int CardProductionPriority { get; set; }
        public string CardNominalName { get; set; }
        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public int ServiceType { get; set; }
        public int ProviderID { get; set; }
        public int GateServiceID { get; set; }
        public bool ServiceAllowQiwiPin { get; set; }
        /// <summary>
        /// contructor null
        /// </summary>
        public PinCard()
        {
        }
        /// <summary>
        /// contructor from xml node
        /// </summary>
        /// <param name="xmlNode"></param>
        public PinCard(XmlNode xmlNode)
        {
            foreach (XmlNode childNode in xmlNode)
            {
                try
                {
                    switch (childNode.Name)
                    {
                        case "CardsCount":
                            this.CardsCount = int.Parse(childNode.InnerText); break;
                        case "CardProductionID":
                            this.CardProductionID = int.Parse(childNode.InnerText); break;
                        case "CardNominalID":
                            this.CardNominalID = int.Parse(childNode.InnerText); break;
                        case "CardNominalName":
                            this.CardNominalName = childNode.InnerText; break;
                        case "CardProductionCost":
                            this.CardProductionCost = decimal.Parse(childNode.InnerText); break;
                        case "CardProductionCount":
                            this.CardProductionCount = int.Parse(childNode.InnerText); break;
                        case "CardProductionDate":
                            this.CardProductionDate = Convert.ToDateTime(childNode.InnerText); break;
                        case "CardProductionPriority":
                            this.CardProductionPriority = int.Parse(childNode.InnerText); break;
                        case "ServiceID":
                            this.ServiceID = int.Parse(childNode.InnerText); break;
                        case "ServiceName":
                            this.ServiceName = childNode.InnerText; break;
                        case "ServiceType":
                            this.ServiceType = int.Parse(childNode.InnerText); break;
                        case "GateServiceID":
                            this.GateServiceID = int.Parse(childNode.InnerText); break;
                        case "ServiceAllowQiwiPin":
                            this.ServiceAllowQiwiPin = bool.Parse(childNode.InnerText); break;
                    }
                }
                catch
                {
                    //can't parse data
                }
            }
        }
    }
}
