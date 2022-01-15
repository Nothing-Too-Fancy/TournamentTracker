using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person
    /// </summary>
    class PersonModel
    {
        /// <summary>
        /// First Name of the player
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last Name of the player
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Email Address of the player
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Phone Number of the Player
        /// </summary>
        public string PhoneNumber { get; set; }
    }
}
