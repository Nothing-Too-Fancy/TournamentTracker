using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class MatchupModel
    {
        /// <summary>
        /// List of Matchup Entries
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; }
        /// <summary>
        /// Winner of the matchup
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Round of the matchup
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
