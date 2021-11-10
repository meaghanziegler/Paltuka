using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pheltuka
{
    public class Main
    {
            public enum Attacks { Fire, Water, Earth, Air }
            public Main() { }
            public Main(string name, int score, int health, int lives)
            {
                Name = name;
                Score = score;
                Health = health;
                Lives = lives;
            }
            public static string Name { get => ""; set { } }
            public static int Score { get => 0; set { } }
            public static int Health { get => 30; set { } }
            public static int Lives { get => 3; set { } }
    }
}
