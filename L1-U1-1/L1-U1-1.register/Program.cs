using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace L1_U1_1.register
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Player> Players = InOutUtils.readFile("Players.csv");
            InOutUtils.PrintOldest(Players);
            List<Player> Attackers = TaskUtils.FindAttackers(Players);
            InOutUtils.PrintAttackers(Attackers);
            List<Player> InvitedPlayers = TaskUtils.FindInvitedPlayers(Players);
            InOutUtils.PrintInvitedToCSVFile("Rinktine.csv", InvitedPlayers);
        }
    }
}