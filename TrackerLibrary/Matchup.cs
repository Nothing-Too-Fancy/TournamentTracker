using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class Matchup
    {
        /// <summary>
        /// List of Matchup Entries
        /// </summary>
        public List<MatchupEntry> Entries { get; set; }
        /// <summary>
        /// Winner of the matchup
        /// </summary>
        public Team Winner { get; set; }
        /// <summary>
        /// Round of the matchup
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
