using PlayMoreGolf;
using System;
using System.Collections.Generic;

namespace golf_program
{
    class ApplicationManager
    {
        public ApplicationManager()
        {
            MaxAttempts = 10;
            TotalDistanceTravelled = 0;
            CourseLength = rnd.Next(580, 1000);
            Swings = new List<Swing>();
        }


        internal double _GRAVITY = 9.8;

        public int CourseLength { get; set; }

        public int MaxAttempts { get; set; }

        public double TotalDistanceTravelled { get; set; }

        public int StrikesSoFar { get; set; }
        public double DistanceToCup { get; set; }
        
        public List<Swing> Swings { get; set; }

        private Random rnd = new Random();

        private Swing _lastStrike = null;


        public void SimulateStrike(int angle, int velocity)
        {
            if (velocity > 58)
            {
                velocity = 58;
            }
            double angleInRadians = (Math.PI / 180) * angle;
            double distance = Math.Pow(velocity, 2) / _GRAVITY * Math.Sin(2 * angleInRadians);

            TotalDistanceTravelled += distance;
            DistanceToCup = (double)CourseLength - TotalDistanceTravelled;

            Swing strike = new Swing();
            strike.Angle = angle;
            strike.Velocity = velocity;
            strike.DistanceTravelled = distance;
            strike.DistanceToCup = DistanceToCup -= TotalDistanceTravelled; 
            _lastStrike = strike;


            Swings.Add(strike);
        }

        public void DisplayStrikesStats()
        {
            
            foreach (var item in Swings)
            {
                Console.WriteLine("Strike: {0}", Swings.IndexOf(item) + 1);
                Console.WriteLine("Angle: {0}", item.Angle);
                Console.WriteLine("Velociy: {0}", item.Velocity);
                Console.WriteLine("Distance: {0}", item.DistanceTravelled);
                Console.WriteLine("Distance left: {0})", item.DistanceToCup);
                Console.WriteLine("------------------------------------");
            }
        }
    }
}