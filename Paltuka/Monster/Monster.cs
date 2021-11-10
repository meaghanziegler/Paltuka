using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pheltuka.Monster;

namespace Pheltuka.Monster
{
   public class Monster
    {
        public static int Health
        {
            get
            {
                if (Main.Health > 20 && Main.Lives > 1)
                {
                    return Health;
                }
                else
                    Console.WriteLine($"Game Over!");
                return Health;
            }
            set
            {

            }
        }
        public static int Lives { get; set; }
        public static int Score { get; set; }
        public static string Name1
        {
            get => "Vampire"; set { }
        }
        public static string Name2
        {
            get => "Dragon"; set { }
        }
        public static string Name3
        {
            get => "Werewolf"; set { }
        }
    }
}
