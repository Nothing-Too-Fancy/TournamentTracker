using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one matchup entry
    /// </summary>
    class MatchupEntryModel
    {
        /// <summary>
        /// Team competing in the Matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Team Score
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Winning matchup from previous round
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
