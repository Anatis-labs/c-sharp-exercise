using System;
using Gladiator_game;

namespace Gladiator_game
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Game_engine combat = new Game_engine();
         
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
                Console.WriteLine("Choise 3: Inventory");
                Console.WriteLine("Choise 4: Exit the game");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        combat.Gladiator();
                        combat.Enemy();
                        combat.Combat();
                       /*
                        Console.WriteLine("glad hp: "+combat.GladiatorHp);
                        Console.WriteLine("glad str: "+combat.GladiatorStr);
                        Console.WriteLine("enemy hp: "+combat.EnemyHp);
                        Console.WriteLine("enemy str: "+combat.EnemyStr);
                        */
                        break;
                    case 2:
                          
                        break;
                    case 3:

                        break;
                    case 4:
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a value between 1-3");
                        break;

                }
            }
        }
    }
}
