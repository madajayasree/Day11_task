using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_Application_SortByBattingStyle
{
    class sortByTeamName : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {

            return x.TeamName.CompareTo(y.TeamName);
        }
    }
}
