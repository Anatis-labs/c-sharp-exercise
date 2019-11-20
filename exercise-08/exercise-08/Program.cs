using System;

namespace exercise_08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Let the user input a decimal number. Then output square root of the
            number and the number raised to the power of 2 and 10.That is √n , n2
            (square root 2), n10(square root 10).
            */

            Console.WriteLine("Please enter a number to do magic math with.");
            decimal input = Convert.ToDecimal(Console.ReadLine());
            
            //raised
            Console.WriteLine("The number you entered raised by 2 is: "+Math.Pow(Convert.ToDouble(input), 2));
            Console.WriteLine("The number you entered raised by 10 is: " + Math.Pow(Convert.ToDouble(input), 10));

            //squared
            Console.WriteLine("The squareroot of the number you entered is: " +Math.Sqrt(Convert.ToDouble(input)));
            
        }
    }
}
