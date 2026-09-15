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
        public static void PrintOldest(List<Player> Players)
        {
            TaskUtils.CheckOldestPlayer(Players);
            Console.WriteLine("Vyriausi zaidejai:");
            Console.WriteLine(new String('-', 44));

            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].oldest)
                {
                    Console.WriteLine("| {0, 10} | {1, 15} | {2, -1:yyyy-mm-dd} |", Players[i].Name, Players[i].Surname, Players[i].BirthDate);
                }
            }
            Console.WriteLine(new String('-', 44));
        }
        public static void PrintAttackers(List<Player> Attackers)
        {
            Console.WriteLine("Puolejai:");
            Console.WriteLine(new String('-', 44));
            foreach (Player player in Attackers)
            {
               Console.WriteLine("| {0, 10} | {1, 15} | {2, -1:yyyy-mm-dd} |", player.Name, player.Surname, player.BirthDate);
            }
            Console.WriteLine(new String('-', 44));
        }

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
        
    }
}