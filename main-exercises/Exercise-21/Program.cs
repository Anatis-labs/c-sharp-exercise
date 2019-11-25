using System;

namespace Exercise_21
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter digits seperated by a ", "");
            string input = Console.ReadLine();
            String[] stringToBeConverted = input.Split(',');
            int[] intList = Array.ConvertAll(stringToBeConverted, int.Parse);

            var min = intList[0];
            var max = intList[0];
            var sum = 0;
            var average = 0;

            for (int i = 0; i < intList.Length; i++)
            {
                sum += intList[i];
            }

            average = sum / intList.Length;

            for (int i=0; i < intList.Length;i++)
            {
                if (max < intList[i])
                    max = intList[i];
                if (min > intList[i])
                    min = intList[i];               
            }
            
            

            Console.WriteLine("The average is:  {0}",average);
            Console.WriteLine("The highest value among the numbers is: {0}",max);
            Console.WriteLine("The lowest value among the numbers is: {0}",min);
        }
    }
}
