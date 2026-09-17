using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace L1_U1_1.register
{
    static class TaskUtils
    {
        /// <summary>
        /// Finds the birth date of the oldest player
        /// </summary>
        /// <param name="player">Collection of all players</param>
        /// <returns>The birth date of the oldest player</returns>
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
        /// <summary>
        /// Checks if there are multiple oldest players
        /// </summary>
        /// <param name="player">Collection of all players</param>
        public static void CheckOldestPlayer (List <Player> player)
        {
            DateTime oldest = FindOldestPlayer(player);
            for (int i = 0; i <  player.Count; i++)
            {
                if(player[i].BirthDate == oldest)
                {
                    player[i].Oldest = true;
                }
            }
        }
        /// <summary>
        /// Forms a new list of players, who are attackers
        /// </summary>
        /// <param name="Players">Collection of all players</param>
        /// <returns>The list of attackers</returns>
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
        /// <summary>
        /// Forms a new list of players, who are invited to the team
        /// </summary>
        /// <param name="Players">Collection of all players</param>
        /// <returns>The list of invited players</returns>
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