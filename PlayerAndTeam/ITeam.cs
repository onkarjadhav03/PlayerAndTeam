using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAndTeam
{
    public interface ITeam
    {
        void Add(Player player);
        void Remove(int playerid);
        void GetPlayerById(int playerId);
        void GetPlayerByName(string playerName);
        List<Player> GetAllPlayers();
    }
}
