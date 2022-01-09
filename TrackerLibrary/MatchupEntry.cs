using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class MatchupEntry
    {
        /// <summary>
        /// Team competing in the Matchup
        /// </summary>
        public Team TeamCompeting { get; set; }
        /// <summary>
        /// Team Score
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Winning matchup from previous round
        /// </summary>
        public Matchup ParentMatchup { get; set; }
    }
}
