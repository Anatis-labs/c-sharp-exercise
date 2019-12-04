using System;
using Gladiator_game;

namespace Gladiator_game
{
    class Main
    {
        static void Main(string[] args)
        {
            Boolean loop = true;
            Console.WriteLine("Welcome to the arena!!");
            Console.WriteLine("The challanger fights untill death, ppl place ur bets");
            Console.WriteLine("What is the name of your fighter: ");
            String gladiatorName = Console.ReadLine();

            Console.WriteLine("Welcome ", gladiatorName, " lets see how strong you are today");


            while (loop)
            {
                Console.WriteLine("Now where do we wanna send the gladiator??");
                Console.WriteLine("Choise 1: Enter the arena and fight untill death");
                Console.WriteLine("Choise 2: See stats of the last fighter");
                Console.WriteLine("Choise 3: Exit the game");

                int choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:


                    case 2:
                        Game_engine ge = new Game_engine;
                        ge.DisplayFightingStats();
                        break;
                    case 3:
                        loop = false;
                        break;
                    default:
                        break;

                }
            }

        }
    }
}
