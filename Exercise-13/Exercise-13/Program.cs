using System;

namespace Exercise_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int answer = random.Next(0,500);

            Console.WriteLine("Please guess the random number between 1 and 500");
            while (true)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
            
                if (guess < answer)
                {
                    Console.WriteLine("Ur guess were too low");
                }
                if (guess > answer)
                {
                    Console.WriteLine("ur guess was too high");
                }
                if (guess == answer)
                {
                    Console.WriteLine("Grats u made it hurray"+ "\n praise satan");
                    break;
                }
            }
        }
    }
}
