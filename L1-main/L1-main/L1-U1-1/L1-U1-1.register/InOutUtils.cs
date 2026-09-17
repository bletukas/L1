using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace L1_U1_1.register
{
    static class InOutUtils
    {
        /// <summary>
        /// Reads the file and forms a list of players
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <returns>The list of all the players</returns>
        public static List<Player> readFile(string fileName)
        {
            List<Player> Players = new List<Player>();
            string[] Lines = File.ReadAllLines(fileName, Encoding.UTF8);
            foreach (string line in Lines)
            {
                string[] Values = line.Split(';');
                string name = Values[0];
                string surname = Values[1];
                DateTime birthDate = DateTime.Parse(Values[2]);
                int height = int.Parse(Values[3]);
                string position = Values[4];
                string club = Values[5];
                bool invited = bool.Parse(Values[6]);
                bool captain = bool.Parse(Values[7]);

                Player player = new Player(name, surname, birthDate, height, position, club, invited, captain);
                Players.Add(player);
            }
            return Players;
        }
        /// <summary>
        /// Prints information of the oldest player or players
        /// </summary>
        /// <param name="Players">List of all players</param>
        public static void PrintOldest(List<Player> Players)
        {
            TaskUtils.CheckOldestPlayer(Players);
            Console.WriteLine("Oldest players:");
            Console.WriteLine(new String('-', 44));
            Console.WriteLine("| {0, -10} | {1, -15} | {2, -10} |", "Name", "Surname", "Birthdate");
            Console.WriteLine(new String('-', 44));

            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].Oldest)
                {
                    Console.WriteLine("| {0, -10} | {1, -15} | {2, 1:yyyy-mm-dd} |", Players[i].Name, Players[i].Surname, Players[i].BirthDate);
                }
            }
            Console.WriteLine(new String('-', 44));
        }
        /// <summary>
        /// Prints all attackers
        /// </summary>
        /// <param name="Attackers">List of all atackers</param>
        public static void PrintAttackers(List<Player> Attackers)
        {
            Console.WriteLine("Attackers:");
            Console.WriteLine(new String('-', 44));
            Console.WriteLine("| {0, -10} | {1, -15} | {2, -10} |", "Name", "Surname", "Birthdate");
            Console.WriteLine(new String('-', 44));
            foreach (Player player in Attackers)
            {
               Console.WriteLine("| {0, -10} | {1, -15} | {2, 1:yyyy-mm-dd} |", player.Name, player.Surname, player.BirthDate);
            }
            Console.WriteLine(new String('-', 44));
        }
        /// <summary>
        /// Prints invited players to a .csv file
        /// </summary>
        /// <param name="fileName">Name of the file</param>
        /// <param name="InvitedPlayers">List of all invited players</param>
        public static void PrintInvitedToCSVFile(string fileName, List<Player> InvitedPlayers)
        {
            string[] lines = new string[InvitedPlayers.Count + 1];
            lines[0] = String.Format("{0};{1};{2};{3};{4};{5};{6};{7}", "Vardas", "Pavardė", "Gimimo d.", "Ūgis",
                "Pozicija", "Klubas", "Pakviestas", "Kapitonas");
            for (int i = 0; i < InvitedPlayers.Count; i++)
            {
                lines[i+1] = String.Format("{0};{1};{2:yyyy-mm-dd};{3};{4};{5};{6};{7}",InvitedPlayers[i].Name, InvitedPlayers[i].Surname, InvitedPlayers[i].BirthDate, InvitedPlayers[i].Height, InvitedPlayers[i].Position, InvitedPlayers[i].Club, InvitedPlayers[i].Invited, InvitedPlayers[i].Captain);
            }
            File.WriteAllLines(fileName, lines, Encoding.UTF8);
        }
        /// <summary>
        /// Prints all data to a file
        /// </summary>
        /// <param name="fileName">name of the file</param>
        /// <param name="Players">List of all players</param>
        public static void PrintAllData(string fileName, List<Player> Players)
        {
            string[] lines = new string[Players.Count + 4];
            lines[0] = String.Format(new string('-', 135));
            lines[1] = String.Format("| {0, -10} | {1, -15} | {2, 10} | {3, 5} | {4, -10} | {5, -15} | {6, -20} | {7, -25} |", "Vardas", "Pavardė", "Gimimo d.", "Ūgis",
                "Pozicija", "Klubas", "Pakviestas", "Kapitonas");
            lines[2] = String.Format(new string('-', 135));
            for (int i = 0; i < Players.Count; i++)
            {
                lines[i+3] = String.Format("| {0, -10} | {1, -15} | {2, 10:yyyy-mm-dd} | {3, 5} | {4, -10} | {5, -15} | {6, -20} | {7, -25} |", Players[i].Name, Players[i].Surname, Players[i].BirthDate, Players[i].Height, Players[i].Position, Players[i].Club, Players[i].Invited, Players[i].Captain);
            }
            lines[Players.Count+3] = String.Format(new string('-', 135));
            File.WriteAllLines(fileName, lines, Encoding.UTF8);
        }
        
    }
}