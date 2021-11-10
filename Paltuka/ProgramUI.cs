using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Pheltuka.Monster;

namespace Pheltuka
{
    public class ProgramUI
    {
        public enum Item { slab, };

        public void Run()
        {
            Console.Clear();
            Console.Beep(432, 100);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Write(
            "████████████████████████████████████████████████\n" +
            "█▄─▄▄─█─█─█▄─▄▄─█▄─▄███─▄─▄─█▄─██─▄█▄─█─▄██▀▄─██\n" +
            "██─▄▄▄█─▄─██─▄█▀██─██▀███─████─██─███─▄▀███─▀─██\n" +
            "▀▄▄▄▀▀▀▄▀▄▀▄▄▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▀▄▄▀\n");
            Music();
            AnyKey();
            Console.Clear();
            Console.WriteLine(
"█▀▀▄ █──█ 　 ░█▀▄▀█ █▀▀ █▀▀▀ 　 █▀▀█ █▀▀▄ █▀▀▄ 　 ░█▀▀█ █▀▀ █▀▀\n" +
"█▀▀▄ █▄▄█ 　 ░█░█░█ █▀▀ █─▀█ 　 █▄▄█ █──█ █──█ 　 ░█▀▀▄ █▀▀ █──\n" +
"▀▀▀─ ▄▄▄█ 　 ░█──░█ ▀▀▀ ▀▀▀▀ 　 ▀──▀ ▀──▀ ▀▀▀─ 　 ░█▄▄█ ▀▀▀ ▀▀▀\n\n\n");
            AnyKey();
            Console.Clear();
            Console.WriteLine(
"█───█ ─▀─ █── █── 　 █──█ █▀▀█ █──█ 　 █▀▀ █▀▀ ▀▀█▀▀ 　 █▀▀█ █──█ ▀▀█▀▀ 　 ▀▀█▀▀ █▀▀█\n" + 
"█▄█▄█ ▀█▀ █── █── 　 █▄▄█ █──█ █──█ 　 ▀▀█ █▀▀ ──█── 　 █──█ █──█ ──█── 　 ──█── █──█\n" +
" ▀─▀─ ▀▀▀ ▀▀▀ ▀▀▀ 　 ▄▄▄█ ▀▀▀▀ ─▀▀▀ 　 ▀▀▀ ▀▀▀ ──▀── 　 ▀▀▀▀ ─▀▀▀ ──▀── 　 ──▀── ▀▀▀▀\n\n\n" +

"█──█ █▀▀▄ █▀▀ █▀▀█ ▀█─█▀ █▀▀ █▀▀█ 　 ▀▀█▀▀ █──█ ─▀─ █▀▀ 　 █── █▀▀█ █▀▀ ▀▀█▀▀ \n"+
"█──█ █──█ █── █──█ ─█▄█─ █▀▀ █▄▄▀ 　 ──█── █▀▀█ ▀█▀ ▀▀█ 　 █── █──█ ▀▀█ ──█── \n" +
"_▀▀▀ ▀──▀ ▀▀▀ ▀▀▀▀ ──▀── ▀▀▀ ▀─▀▀ 　 ──▀── ▀──▀ ▀▀▀ ▀▀▀ 　 ▀▀▀ ▀▀▀▀ ▀▀▀ ──▀── \n\n\n" +

"█▀▀ ─▀─ ▀█─█▀ ─▀─ █── ─▀─ ▀▀█ █▀▀█ ▀▀█▀▀ ─▀─ █▀▀█ █▀▀▄ ▀█ \n" +
"█── ▀█▀ ─█▄█─ ▀█▀ █── ▀█▀ ▄▀─ █▄▄█ ──█── ▀█▀ █──█ █──█ █▀ \n" +
"▀▀▀ ▀▀▀ ──▀── ▀▀▀ ▀▀▀ ▀▀▀ ▀▀▀ ▀──▀ ──▀── ▀▀▀ ▀▀▀▀ ▀──▀ ▄─\n" +
  "Type START or YES to start game, then press the ENTER key twice.");
            string command = Console.ReadLine().ToLower();
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.ReadLine();
                if (command.StartsWith("yes") || command.StartsWith("start"))
                {
                    StartGame();
                }
                if (command.StartsWith("no") || command.StartsWith("end"))
                {
                    continueToRun = false;
                }

            }
            void StartGame()
            {
                Console.Clear();
                Thread.Sleep(1000);
                Console.Beep(100, 200);
                Console.WriteLine("You are a former archeologist. You were recently fired for your obsession with this lost civilization, Pheltuka.\n");
                Thread.Sleep(2000);
                AnyKey();
                Console.Clear();
                Thread.Sleep(1000);
                Console.Beep(100, 200);
                Console.WriteLine("The only clues you have that Pheltuka civilization even existed is from some old broken pottery\nand a busted writing slab that you have been trying to dechpiher for 5 years.\n");
                Thread.Sleep(2000);
                AnyKey();
                Console.Clear();
                Thread.Sleep(1000);
                Console.Beep(100, 200);
                Console.WriteLine("You have only translated a small portion of the slab, but you found out that this text talks\nabout trading with Pheltuka and the Uuprese river is the only way to get to Pheltuka.\n");
                Thread.Sleep(2000);
                AnyKey();
                Console.Clear();
                Thread.Sleep(2000);
                Console.WriteLine("You wake up to the sound of running water.");
                Thread.Sleep(2000);
                Console.WriteLine("You're on an island that you set up camp on.\n");
                Thread.Sleep(2000);
                AnyKey();
                Console.Clear();
                Console.WriteLine("You decide to go for a walk to see if you can find some firewood..");
                Thread.Sleep(2000);
                Console.WriteLine("You come across an abandoned hut and decide to investigate.\n\n");
                Thread.Sleep(2000);
                AnyKey();
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("When suddenly you're attacked by a vampire!!\n\n");
                Console.WriteLine("You have two options:\n" +
                    "to Flee, type FLEE\n" +
                    "To attack, type ATTACK");
                string input = Console.ReadLine().ToLower();
                if (input is "flee")
                {
                    Main.Lives = Main.Lives - 1;
                    Console.Clear();
                    Flee();
                }
                else if (input is "attack")
                {
                    Main.Health = Main.Health - 5;
                    AttackVampire();
                }
                AnyKey();
                Console.Clear();
                Console.WriteLine("You come across a fork in the trail, you have three options.\n");
                Console.Beep(200, 100);
                Console.WriteLine("To go left, type LEFT.\n" +
                                  "To go right, type RIGHT\n" +
                                  "To go straight, type STR8\n");
                string direction1 = Console.ReadLine().ToLower();

                switch (direction1)
                {
                    case "right":
                        Console.WriteLine("You encounter a werewolf");
                        Console.Beep(432, 100);
                        Console.Beep(500, 100);
                        Console.WriteLine("You have two options");
                        Thread.Sleep(200);
                        Console.WriteLine("Type ATTACK or FLEE");
                        string input3 = Console.ReadLine().ToLower();
                        break;
                    case "left":
                        Console.WriteLine("You fell off a cliff, GAME OVER.");
                        Console.Clear();
                        StartGame();
                        break;
                    case "str8":
                        Console.WriteLine("You encounter another fork in the road, on down!");
                        Console.WriteLine("To go left, type LEFT.\n" +
                        "To go right, type RIGHT\n");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("I don't understand that command.");
                        AnyKey();
                        break;


                }


            }
            //HELPER METHODS

            }
            public void DirectionMenu()
            {
                Console.WriteLine("Go STRAIGHT, LEFT, RIGHT");
                string directionInput = Console.ReadLine().ToLower();
                switch (directionInput)
                {
                    case "straight":
                    default:
                        break;
                    case "right":
                        break;
                    case "left":
                        break;
                }
            }
            public static void AnyKey()
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            public static void Flee()
            {
                if (Main.Lives >= 1)
                {
                    Console.WriteLine($"You evaded the Vampire\n\n" +
                        $"But you lost a life for being a coward. Lives: {Main.Lives}");
                }
                else
                    Console.WriteLine("You couldn't escape! Game Over!");
            }
            public static void AttackVampire()
            {
                if (Main.Health > 10)
                {
                    Console.Beep(432, 200);
                    Console.WriteLine($"You attacked the Vampire\n");
                    AnyKey();
                    Console.Clear();
                    Console.WriteLine($"He attacked back!! Your health is now {Main.Health = Main.Health - 5}");
                    Console.Beep(200, 400);
                    Console.WriteLine("Continue to attack?");
                    Console.Beep(200, 400);
                    AnyKey();
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"You killed the Vampire.\n\nYour score is: {Main.Score + 5} Your health is: {Main.Health} You have {Main.Lives} lives\n\n\n");
                    Console.Beep(432, 200);
                }
                else if (Main.Health < 10)
                {
                    Console.WriteLine("You don't have enough strength to complete this action");
                }
            }
        public static void AttackWerewolf()
        {
            if (Main.Health > 10)
            {
                Console.Beep(432, 200);
                Console.WriteLine($"You attacked the Werewolf\n");
                AnyKey();
                Console.Clear();
                Console.WriteLine($"He attacked back!! Your health is now {Main.Health = Main.Health - 10}");
                Console.Beep(200, 400);
                Console.WriteLine("Continue to attack?");
                Console.WriteLine($"He attacked back!! Your health is now {Main.Health = Main.Health - 10}");
                Console.Beep(200, 400);
                Console.WriteLine("Continue to attack?");
                Console.Beep(200, 400);
                AnyKey();
                Console.Clear();
                Console.WriteLine($"You killed the Werewolf.\n\nYour score is: {Main.Score + 5} Your health is: {Main.Health} You have {Main.Lives} lives\n\n\n");
                Console.Beep(432, 200);
            }
            else if (Main.Health < 10)
            {
                Console.WriteLine("You don't have enough strength to complete this action");
            }
        }

        //HELPER METHODS
        public static void Music()
            {
                Console.Beep(261, 200);
                Console.Beep(329, 400);
                Console.Beep(392, 200);
                Console.Beep(440, 400);
                Console.Beep(261, 200);
                Console.Beep(392, 400);
                Console.Beep(440, 400);
                Console.Beep(329, 400);
            }
            public static void CreateRandomMonster(string Monster)
            {
                Random monster = new Random(3);

                string[] randomMonsters = new string[]
                {
                "Vampire",
                "Werewolf",
                "Ice Wraith",
                "Fire Dragon"
                };

                int randomNumber = monster.Next(0, randomMonsters.Length);

                string chosenMonster = randomMonsters.ElementAt(randomNumber);
                Console.WriteLine(randomMonsters);
        }
    }
}
