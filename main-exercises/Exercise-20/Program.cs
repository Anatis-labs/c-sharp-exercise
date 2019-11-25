using System;

namespace Exercise_20
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int arraySize = random.Next(1, 50);
            int[] lineOne = new int[arraySize];
            int[] lineTwo = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                lineOne[i] = random.Next(1,25);
            }

            Console.WriteLine("The first array");
            foreach (int test in lineOne)
            {
                Console.Write(test);
            }

            Array.Sort(lineOne);
           for (int i=0; i < arraySize;i++)
            {
                lineTwo[i] = lineOne[i];
            }
            Console.WriteLine("\n the first array sorted");
            foreach (int test in lineTwo)
            {
                Console.Write(test);
            }

        }
    }
}
