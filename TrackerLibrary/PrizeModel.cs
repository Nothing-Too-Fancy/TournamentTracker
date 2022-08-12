using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one prize
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The place number this prize is awarded to
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The place name this prize is awarded to
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Prize Amount in dollars
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Prize amount as a percentage of total pool
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
