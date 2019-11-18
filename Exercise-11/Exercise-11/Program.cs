using System;

namespace Exercise_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            Console.WriteLine("Idealy between 1 and 100");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("The value has to be over 0");
            }

            int goingup = 0;
            for (int i=0; i <= number; i++)
            {
                if (goingup % 2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(goingup);
                goingup++;
            }

            int goingdown = number;
            for (int i=0; i <= number; i++)
            {
                if (goingdown % 2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }    
                Console.WriteLine(goingdown);
                goingdown--;

            }
        }
    }
}
