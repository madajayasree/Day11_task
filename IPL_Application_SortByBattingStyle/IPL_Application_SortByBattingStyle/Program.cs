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
                    {
                        Console.WriteLine("Enter {0} player details separated by kamas in the format of teamname,country, id,name,age,battingstyle,bowlingstyle", i + 1);
                        string jobDetails = Console.ReadLine();
                        Player p = Player.createPlayer(jobDetails);
                        player_obj[i] = p;
                    }


                }
                
                //Asking users choice for sorting team players

            Console.WriteLine("press1:sort by TeamName, press2:sort by BattingStyle");
            int press = int.Parse(Console.ReadLine());
            switch(press)
            {
                case 1:
                    Console.WriteLine("Sorting by Team name");
                    Player_BO p = new Player_BO();
                    Array.Sort(player_obj, p);
                    break;
                case 2:
                    Console.WriteLine("Sorting by batting Style");
                    Array.Sort(player_obj);
                    break;


            }
            foreach (var item in player_obj)
            {
                     Console.WriteLine(item);
            }





        }
    }
}
