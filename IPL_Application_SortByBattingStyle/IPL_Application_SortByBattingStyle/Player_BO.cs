using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_Application_SortByBattingStyle
{
    class Player_BO 
    {
                       
        public Player[] searchByTeamName(Player[] playersList)
        {
            Player[] results = null;
            sortByTeamName ascSortByTeam = new sortByTeamName();
            Array.Sort(playersList, ascSortByTeam);
            results = playersList;
            return results;

        }

        public Player[] searchByBattingStyle(Player[] playersList)
        {
            Player[] results=null;
            sortDesPlayer sdp = new sortDesPlayer();
            Array.Sort(playersList, sdp);
            Array.Reverse(playersList);
            results = playersList;
            return results;

        }

    }

}
