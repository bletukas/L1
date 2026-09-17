using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace L1_U1_1.register
{
    internal class Program
    {
        /// <summary>
        /// Main class, only calls other methods.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            List<Player> Players = InOutUtils.readFile("Players.csv");
            ///Reading the data file
            InOutUtils.PrintOldest(Players);
            ///Printing the oldest player to console.
            List<Player> Attackers = TaskUtils.FindAttackers(Players);
            if (Attackers.Count == 0) 
            {
                Console.WriteLine("No attackers");
            }
            ///Checking if the list is empty
            else
            {
                InOutUtils.PrintAttackers(Attackers);
                ///Printing attackers
            }
            List<Player> InvitedPlayers = TaskUtils.FindInvitedPlayers(Players);
            if (InvitedPlayers.Count == 0)
            {
                Console.WriteLine("There are no invited players");
            }
            ///Checking if the list is empty
            else
            {
                InOutUtils.PrintInvitedToCSVFile("Rinktine.csv", InvitedPlayers);
                ///Printing invited player to a .csv file.
            }
            InOutUtils.PrintAllData("Duomenys.txt", Players);
        }
    }
}