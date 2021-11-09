using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_Application_SortByBattingStyle
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter how many playes you want to enter");
            int player_count;
            player_count = Convert.ToInt32(Console.ReadLine());

            Player[] player_obj = new Player[player_count];
            for (int i = 0; i < player_count; i++)
            {

                Console.WriteLine("Enter {0} player details separated by kamas in the format of teamname,country, id,name,age,battingstyle,bowlingstyle", i + 1);
                string jobDetails = Console.ReadLine();
                Player p = Player.createPlayer(jobDetails);
                player_obj[i] = p;



            }



            //Asking users choice for sorting team players

            Console.WriteLine("1:sort by TeamName, 2:sort by BattingStyle");
            int press = int.Parse(Console.ReadLine());
            Player_BO obj_playerBo = new Player_BO();
            Player[] sortedPlayerDetails = null;

            switch (press)
            {
                case 1:
                    Console.WriteLine("Sorting by Team name in asecnding order");
                    sortedPlayerDetails = obj_playerBo.searchByTeamName(player_obj);

                    break;
                case 2:
                    Console.WriteLine("Sorting by Batting Style  in desending order");

                    sortedPlayerDetails = obj_playerBo.searchByBattingStyle(player_obj);

                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            if (sortedPlayerDetails != null)
            {

                foreach (var item in sortedPlayerDetails)
                {
                    Console.WriteLine(item);
                }
            }

                








        }
    }
}

