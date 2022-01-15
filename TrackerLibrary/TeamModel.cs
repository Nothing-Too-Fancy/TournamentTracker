using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one teams
    /// </summary>
    class TeamModel
    {
        /// <summary>
        /// List of players on the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// Name of the team
        /// </summary>
        public string TeamName { get; set; }
    }
}
