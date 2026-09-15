using System;
using System.Collections.Generic;

namespace L1_U1_1.register
{
    static class TaskUtils
    {
        public static DateTime FindOldestPlayer(List<Player> player)
        {
            DateTime oldest = player[0].BirthDate;

            for (int i = 1; i < player.Count; i++)
            {
                if (DateTime.Compare(player[i].BirthDate, oldest) < 0)
                {
                    oldest = player[i].BirthDate;
                }
            }

            return oldest;
        }
        public static void CheckOldestPlayer (List <Player> player)
        {
            DateTime oldest = FindOldestPlayer(player);
            for (int i = 0; i <  player.Count; i++)
            {
                if(player[i].BirthDate == oldest)
                {
                    player[i].oldest = true;
                }
            }
        }

        public static List<Player> FindAttackers(List<Player> Players)
        {
            List<Player> Attackers = new List<Player>();
            foreach (Player player in Players)
            {
                if (player.Position == "Puolejas" || player.Position == "puolejas" || player.Position == "Puolėjas"  || player.Position == "puolėjas")
                {
                    Attackers.Add(player);
                }
            }
            return Attackers;
        }

        public static List<Player> FindInvitedPlayers(List<Player> Players)
        {
            List <Player> Invited = new List<Player>();
            foreach (Player player in Players)
            {
                if (player.Invited)
                {
                    Invited.Add(player);
                }
            }

            return Invited;
        }
    }
}