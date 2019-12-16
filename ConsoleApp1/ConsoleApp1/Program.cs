using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int[] greger = new int[10] { 0, 5, 3, 6, 2, 4, 7, 9, 8, 1 };
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    if (greger[i] < greger[j])
                    {
                        temp = greger[i];
                        greger[i] = greger[j];
                        greger[j] = temp;
                    }
            }
            foreach (int item in greger)
            {
                Console.WriteLine(item);
            }
        }
    }
}
