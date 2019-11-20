using System;

namespace Exercise_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 0;
            int test2 = 1;
            int test3 = 0;
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            
            {
                Console.WriteLine(test3);
                test3 = test + test2;
                test = test2;
                test2 = test3;
              
           
            }
        }
    }
}
