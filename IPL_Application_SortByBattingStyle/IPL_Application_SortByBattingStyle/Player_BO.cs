﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_Application_SortByBattingStyle
{
    class Player_BO : IComparer<Team>
    {
        // sorting by team name using Icomparer
            public int Compare(Team x, Team y)
            {
                return x.TeamName.CompareTo(y.TeamName);
            }
        

    }

}
