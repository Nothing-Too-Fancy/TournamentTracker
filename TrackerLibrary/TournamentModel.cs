using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class TournamentModel
    {
        /// <summary>
        /// Name of the Tournament
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Entry fee dollar amount
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// List of teams entered in this tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; }
        /// <summary>
        /// List of prizes for this tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; }
        /// <summary>
        /// List of matchups of each round
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; }
    }
}
