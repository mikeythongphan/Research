using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsServiceAutoBuyPincard.Systems
{
    public class InventoryPinCode
    {
        public string ProviderID { get; set; }
        public string ServiceID { get; set; }
        public string CardProductionID { get; set; }
        public string ServiceName { get; set; }
        public double CardsCount { get; set; }
        public string CardProductionCost { get; set; }
        public string CardNominalName { get; set; }
        public string ConsolidatorCostNo { get; set; }
        public double? MinCardsCount { get; set; }
        public double Amount { get; set; }
        public double Cost { get; set; }
        public int NumberNeedBuy { get; set; }
    }
}
