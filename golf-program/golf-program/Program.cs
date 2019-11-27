using System;

namespace golf_program
{

    class Program
    {
        static void Main(string[] args)
        {
            ApplicationManager am = new ApplicationManager();

            am.SimulateStrike(45, 56);
            am.SimulateStrike(45, 32);
            am.DisplayStrikesStats();



            /*while (Ge.Strikes.count < 10)
            {
                Ge.AskFoPlayerInput();
                Ge.SimulateStrike(Ge.CurrentAngle, ge.);
            
            
            }*/

        }

    }
}
