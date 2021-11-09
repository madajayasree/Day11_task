using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPL_Application_SortByBattingStyle
{
    class Player :Team , IComparable
    {
        //Fields
        int id;
        string name;
        int age;
        string battingStyle;
        string bowlingStyle;

        //Constructor
        public Player()
        {
        }

        //own Constructor
        public Player(string teamName, string country, int id, string name, int age, string battingStyle, string bowlingStyle)
            : base(teamName, country)
        {

            Id = id;
            Name = name;
            Age = age;
            BattingStyle = battingStyle;
            BowlingStyle = bowlingStyle;
        }

        public Player(int id, string name, int age, string battingStyle, string bowlingStyle)
        {
            Id = id;
            Name = name;
            Age = age;
            BattingStyle = battingStyle;
            BowlingStyle = bowlingStyle;
        }

        //Properties
        public int Id { get => id; set => id = value; }
              public string Name { get => name; set => name = value; }
              public int Age { get => age; set => age = value; }
              public string BattingStyle { get => battingStyle; set => battingStyle = value; }
              public string BowlingStyle { get => bowlingStyle; set => bowlingStyle = value; }

        //override tostring method
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6}", TeamName, Country, id, name, age, battingStyle, bowlingStyle);
        }
        //override hashmethod
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //equals method
        public override bool Equals(object obj)
        {
            Player p = (Player)obj;
            return this.Name.Equals(p.Name) && this.TeamName.Equals(p.TeamName);
        }

        //Creating a players method
        public static Player createPlayer(string playerDetails)
        {
            string[] s = playerDetails.Split(',');
            Player p = new Player(s[0], s[1], int.Parse(s[2]), s[3], int.Parse(s[4]), s[5], s[6]);
            return p;
        }

        //sorting by batting style using Comparable method 
        public int CompareTo(object obj)
        {
            Player p = (Player)obj;
            return this.battingStyle.CompareTo(p.battingStyle);
                
        }






       
    }


}

