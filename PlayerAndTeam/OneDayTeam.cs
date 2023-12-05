using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAndTeam
{
    internal class OneDayTeam :ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public int capacity { get; set; }
        public OneDayTeam()
        {
            capacity = 11;
        }
        public void Add(Player player)
        {
            if (oneDayTeam.Count != capacity)
            {
                Console.Write("Enter Player Id: ");
                player.PlayerId = int.Parse(Console.ReadLine());
                Console.Write("Enter Player Name: ");
                player.PlayerName = Console.ReadLine();
                Console.Write("Enter Player Age: ");
                player.PlayerAge = int.Parse(Console.ReadLine());
                oneDayTeam.Add(player);
                Console.WriteLine("Player Added Successfully");
            }
            else
            {
                Console.WriteLine("Exceeded team limit of 11");
            }
        }
        public void Remove(int playerid)
        {
            foreach (Player player in oneDayTeam.ToList())
            {
                if (playerid == player.PlayerId)
                {
                    oneDayTeam.Remove(player);
                    Console.WriteLine("Player Removed Successfully");
                }
            }
        }
        public void GetPlayerById(int playerId)
        {
            foreach (Player player in oneDayTeam.ToList())
            {
                if (player.PlayerId == playerId)
                {
                    Console.WriteLine(player.PlayerId + " " + player.PlayerName + " " + player.PlayerAge);
                }
            }
        }
        public void GetPlayerByName(string playerName)
        {
            foreach (Player player in oneDayTeam.ToList())
            {
                if (player.PlayerName == playerName)
                {
                    Console.WriteLine(player.PlayerId + " " + player.PlayerName + " " + player.PlayerAge);
                }
            }
        }
        public List<Player> GetAllPlayers()
        {
            foreach (Player player in oneDayTeam.ToList())
            {
                Console.WriteLine(player.PlayerId + " " + player.PlayerName + " " + player.PlayerAge);
            }
            return oneDayTeam;
        }
    }
}
