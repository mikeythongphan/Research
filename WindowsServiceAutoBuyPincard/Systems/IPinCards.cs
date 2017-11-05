using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsServiceAutoBuyPincard.Systems
{
    public interface IPinCards
    {
        /// <summary>
        /// Creates the pin cards.
        /// </summary>
        /// <param name="productionID">The production ID.</param>
        /// <param name="objPinCard">The obj pin card.</param>
        /// <param name="pincardCost">The pincard cost.</param>
        /// <returns></returns>
        bool CreatePinCards(int productionID, Models.PinCard objPinCard, string pincardCost);
        /// <summary>
        /// Gets the available pincards.
        /// </summary>
        /// <returns>List of availavle pincards</returns>
        List<InventoryPinCode> GetAvailablePincards();
        /// <summary>
        /// Gets the available pin cards by min cards count.
        /// </summary>
        /// <param name="minCardsCount">The min cards count.</param>
        /// <returns>List of available pincard by min card count</returns>
        List<InventoryPinCode> GetAvailablePinCardsByMinCardsCount(double minCardsCount);
        InventoryPinCode GetAvailablePinCardsByMinCardsCountAndCardProductionID(double? minCardsCount, string cardProductionID);
        string GetConsolidatorNo(int consolidatorID);
        string GetPincardNominalCode(int cardProductionID, int consolidatorID);
        string GetPincardNominalCode(int cardProductionID, string serviceID);
    }
}
