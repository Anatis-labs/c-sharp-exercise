using System;
using PlayMoreGolf;


namespace golf_program
{

    class Program
    {
        static void Main(string[] args)
        {
            ApplicationManager am = new ApplicationManager();
            int velocity;
            int angle;
            int trys = 0;
  

            while (am.DistanceToCup >= 0 || trys  == 10)
            {
                Console.WriteLine("please enter angle: ");
                angle = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter velocity: ");
                velocity = int.Parse(Console.ReadLine());

                am.SimulateStrike(angle, velocity);
                am.DisplayStrikesStats();
                if (am.DistanceToCup < 0)
                {
                    am.DistanceToCup = -am.DistanceToCup;
                }
            }
        }
    }
}
