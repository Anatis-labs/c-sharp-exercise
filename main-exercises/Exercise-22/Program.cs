using System;

namespace Exercise_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int damage = 0;
            int hp = 100;

            while (hp > 0)
            {
                Console.WriteLine("press 1 to shoot him in the head");
                Console.WriteLine("press 2 to shoot him in the shoulder");
                Console.WriteLine("press 3 to shoot him in the knee");
                int choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine();
                        damage = +100;
                        Console.WriteLine("The brain would be splattered if he had one, but there is a hole in his head");
                        break;

                    case 2:
                        Console.WriteLine();
                        damage = +35;
                        Console.WriteLine("He can no longer move his arm");
                        break;

                    case 3:
                        Console.WriteLine();
                        damage = +25;
                        Console.WriteLine("the knee is busted he cant escape anymore");
                        break;

                    default:
                        { break; }

                }
                hp -= damage;


                if (hp <= 0)
                { Console.WriteLine("grats u killed him"); }
                Console.WriteLine("current hp: {0}", hp);
            }
        }
    }
}
