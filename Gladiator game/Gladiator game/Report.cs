using Gladiator_game;
using System;
using System.Collections.Generic;
using System.IO;

// create game reports

namespace GladiatorGame
{
    class Report
    {
        public string path = (@"C:\Users\db_gb\OneDrive\Dokument\gladiator save file.txt");
        public string pathHighscore = (@"C:\Users\db_gb\OneDrive\Dokument\gladiatorHighscore file.txt");
        public List<String> Score { get; set; }

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

        public void SaveScore(string name, int points)
        {
            string z = ""; 
            using (StreamWriter file = File.AppendText(pathHighscore))
            {
                /*
                if (points ==0)
                { z = "000"; }
                if (points < 1000)
                {
                    z = "0";
                }
                */
                file.WriteLine("Points accuired: {3}{0} Gladiator name: {1} at {2}", points, name, DateTime.Now, z);
            }
        }



        public void Highscore(string name, List<string> Score)
        {
            HighScore Hscore = new HighScore();
            var fileStream = new FileStream(pathHighscore, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    Hscore.Score.Add(line);                    
                }
            }
        }

        public void Import()
        {
            HighScore Hscore = new HighScore();
            var list = new List<String>();
            string line = "";
            var fileStream = new FileStream(pathHighscore, FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream))

               
            while ((line = streamReader.ReadLine()) != null)
            {
                list.Add(line);
            }

            list.Sort();
            list.Reverse();
            foreach(string item in list)
            {                
                Hscore.Score.Add(item);
            }
            foreach (string item in Hscore.Score)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }

        /*
            public void Highscore(string name, List<string> Score)
            {
                using (StreamWriter file = File.AppendText(pathHighscore))
                {
                    file.Write("\n The gladiator name was: {0} \n The accumulated points were: {1} \n The game was played at: {2} \n \n", name, DateTime.Now);
                    foreach (string line in Score)
                    {
                        {
                            file.WriteLine(line);
                        }
                    }
                }
            }
            */

    }
}