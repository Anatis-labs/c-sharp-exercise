using System;

namespace exercise_17
{
    class Program
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }




        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to see if its a palindrome sentence, simply put if u can flip it and its still the same word.");
            Console.WriteLine("The program will end when u find one");
            while (true)
            {
                String input = Console.ReadLine();
                String Compare = ReverseString(input);

                if (input == Compare)
                {
                    Console.WriteLine("hurray you found one, the program has done its task, and is going to rest.");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry not one, try again");
                }
                Console.WriteLine("the word u wrote:");
                Console.WriteLine(input);
                Console.WriteLine("The word u wrote in reverse");
                Console.WriteLine(Compare);
            }
        }
    }
}
