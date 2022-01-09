using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    class Team
    {
        /// <summary>
        /// List of players on the team
        /// </summary>
        public List<Person> TeamMembers { get; set; }
        /// <summary>
        /// Name of the team
        /// </summary>
        public string TeamName { get; set; }
    }
}
