using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one matchup
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// List of Matchup Entries
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
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
