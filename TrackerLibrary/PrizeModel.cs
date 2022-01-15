using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one prize
    /// </summary>
    class PrizeModel
    {
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
    }
}
