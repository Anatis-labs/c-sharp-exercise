using System;

namespace Exercise_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] money = new int[8] { 500, 100, 50, 20, 10, 5, 2, 1 };
            int[] output = new int[8];
            int[] amountOfBills = new int[8];

            Console.WriteLine("Please enter the handed sum");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the price");
            int price = int.Parse(Console.ReadLine());
            int change = input - price;
            

            for (int i = 0; i < 8; i++)
            {
                if (change >= money[i])
                {
                    output[i] = (change % money[i]);
                    amountOfBills[i] = change / money[i];
                    if (output[i] >= 0)
                    {
                        change = output[i];
                    }
                }
            }
            Console.WriteLine("ending in a totals of " + (input - price) + " in return");
            Console.WriteLine("fivehundeds: " + amountOfBills[0] + " hundreds: " + amountOfBills[1] + " fifties: " + amountOfBills[2] + " tventies: " + amountOfBills[3] + " tens: " + amountOfBills[4] + "fives: " + amountOfBills[5] + " twos: " + amountOfBills[6] + " ones: " + amountOfBills[7]);
        }
    }
}
