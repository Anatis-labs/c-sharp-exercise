using System;
using System.Collections.Generic;
using System.IO;

// create game reports

namespace GladiatorGame
{
    class Report
    {
        public string path = (@"C:\Users\db_gb\OneDrive\Dokument\gladiator save file.txt");
        public void SaveStats(string name, int points, List<string> Slaughtered)
        {
            using (StreamWriter file = File.AppendText(path))
            {
                file.Write("\n The gladiator name was: {0} \n The accumulated points were: {1} \n The game was played at: {2} \n \n", name, points, DateTime.Now);
                foreach (string line in Slaughtered)
                {
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }
    }
}