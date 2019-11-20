using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            int sum = 0;
            Console.WriteLine("Enter as many numbers as u want, \n if u enter -1 the program will give u the sumaverage of the entered numbers");
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number == -1)
                {
                    break;
                }
                else
                {
                    intList.Add(number);
                }
            }

            foreach (var print in intList)
            {
                sum = (sum + print);
            }
            Console.WriteLine("The sum of the numbers is:" + sum);
            if (intList.Count > 0)
            {
                double average = intList.Average();
                Console.WriteLine("The average of the numbers are:" + average);
            }
        }
    }
}