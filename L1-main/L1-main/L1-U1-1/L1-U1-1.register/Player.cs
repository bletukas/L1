using System;
using System.Net.Mime;
using System.Runtime.CompilerServices;

namespace L1_U1_1.register
{
    /// <summary>
    /// Stores the information about players
    /// </summary>
    class Player
    {
        /// <summary>
        /// Name of the player
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Surname of the player
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Birth date of the player
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Height of the player
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// Position of the player
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// Club where the player plays
        /// </summary>
        public string Club { get; set; }
        /// <summary>
        /// Is the player invited to the team
        /// </summary>
        public bool Invited { get; set; }
        /// <summary>
        /// Is the player a captain of their team
        /// </summary>
        public bool Captain { get; set; }
        /// <summary>
        /// Is the player oldest
        /// </summary>
        public bool Oldest {  get; set; }
        /// <summary>
        /// Creates a player object and assigns initial values
        /// </summary>
        /// <param name="name">Name of the player</param>
        /// <param name="surname">Surname of the player</param>
        /// <param name="birthDate">Birthdate of the player</param>
        /// <param name="height">Height of the player</param>
        /// <param name="position">Position of the player</param>
        /// <param name="club">Club of the player</param>
        /// <param name="invited">Is the player invited to the team</param>
        /// <param name="captain">Is the player a captain of their team</param>
        public Player(string name, string surname, DateTime birthDate, int height, string position, string club, bool invited, bool captain) 
        {
            this.Name = name;
            this.Surname = surname;
            this.BirthDate = birthDate;
            this.Height = height;
            this.Position = position;
            this.Club = club;
            this.Invited = invited;
            this.Captain = captain;
        }

    }
    
    
}