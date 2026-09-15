using System;
using System.Net.Mime;
using System.Runtime.CompilerServices;

namespace L1_U1_1.register
{
    class Player
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int Height { get; set; }
        public string Position { get; set; }
        public string Club { get; set; }
        public bool Invited { get; set; }
        public bool Captain { get; set; }
        public bool oldest = false;
        
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