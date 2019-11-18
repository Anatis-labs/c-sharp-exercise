using System;

namespace exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean loop = true;
            while (loop) { 
            Console.WriteLine("Please chose a option:");
            Console.WriteLine("Option 1: enter 2 digits get a divived by b");
            Console.WriteLine("Option 2: ");
            Console.WriteLine("Option 3:Swap the colors of the console");
            Console.WriteLine("Option 4: Close the program");
            int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("please enter 2 numbers");
                        Console.WriteLine("Enter the first number");
                        double number1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Please enter the 2nd number");
                        double number2 = Convert.ToDouble(Console.ReadLine());

                        if (number2 <= 0)
                        {
                            Console.WriteLine("value 2 is too small");
                            break;
                        }
                        else
                            Console.WriteLine("first number divded with the 2nd number is:" + (number1 / number2));
                        break;
                    case 2:

                        break;

                    case 3:

                        if (Console.ForegroundColor == ConsoleColor.Red)
                        {
                            Console.WriteLine("The color will now swap to red");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        }
                        if (Console.ForegroundColor == ConsoleColor.Blue)
                        {
                            Console.WriteLine("The color will now swap to red");
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        }
                        
                        else
                        {
                            Console.WriteLine("The color will now swap to blue");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        }
                        
                    case 4:
                        loop = false;
                        break;
                }


            }


        }
    }
}
