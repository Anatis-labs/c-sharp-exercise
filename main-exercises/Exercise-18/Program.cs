using System;

namespace Exercise_18
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int[] number1 = new int[10];
            double[] number2 = new double[10];

            for (int i = 0; i <= 9; i++)
            {
                number1[i] = random.Next(1, 100);
            }

            foreach (int print1 in number1)
            {
                Console.WriteLine(print1);
            }

            Console.WriteLine();

            for (int i = 0; i <= 9; i++)
            {
                number2[i] = (1/Convert.ToDouble(number1[i]));
            }

            foreach(double print2 in number2)
            {
                Console.WriteLine(print2);
            }
        }
    }
}




