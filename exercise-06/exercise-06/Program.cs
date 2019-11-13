using System;

namespace exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Exercise 6
            Write the program code that lets the user input 2 integers from the console.
            Then let the program output the biggest, smallest, difference ( - ), sum (+),
            product ( * ) and ratio ( / ) between the two numbers.
            Subjects Covered:
            Mathematical operators

             */

            Console.WriteLine("Add 2 numbers and lets do some math");
            Console.WriteLine("Write in ur first digit");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ur 2nd number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            //bigest and lowest
            Console.WriteLine("the largest of the 2 numbers is: " + Math.Max(number1, number2));
            Console.WriteLine("the smallest of the 2 numbers is: " + Math.Min(number1,number2));
            
            //diffrence     
            Console.WriteLine("the diffrence between the 2 is: " + ((Math.Max(number1, number2)-Math.Min(number1, number2))));

            Console.WriteLine("The sum of the 2 is: "+ (number1+number2));

            Console.WriteLine("the 2 times each other is: "+ (number1*number2));

            Console.WriteLine("The 2 numbers divided by each other is: " + ((Math.Max(number1, number2) / Math.Min(number1, number2))));
        }
    }
}
