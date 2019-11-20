using System;

namespace Exercise_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] money = new int[8] { 500, 100, 50, 20, 10, 5, 2, 1 };
            int[] output = new int[8];
            int input = int.Parse(Console.ReadLine());
            int price = 432;

            for (int i = 0; i < 8; i++)
            {
                output[i] = price % money[i];      
            }
            foreach (int test in output)
            {
                Console.WriteLine(test);   
            }

        }
    }
}
