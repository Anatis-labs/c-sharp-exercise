using System;

namespace Exercise_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int loop = 0;
            int greger = 1;
            Console.WriteLine("to activate the search press enter");
            Console.ReadLine();
            Console.WriteLine("May the search for the magic numer begin");
            while (loop < 3)
            {
                for (int i = 1; i < greger; i++)
                {
                    if (greger % i == 0)
                    {
                        //Console.WriteLine(i);
                        sum += i;
                    }
                }

                if (greger == sum)
                {
                    Console.WriteLine(sum);
                    loop++;
                }
                greger++;
                sum = 0;
            }
        }
    }
}