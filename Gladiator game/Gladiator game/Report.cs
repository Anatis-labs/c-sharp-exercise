using Gladiator_game;
using System;
using System.Collections.Generic;
using System.IO;

// create game reports

namespace GladiatorGame
{
    class Report
    {
        public Report()
        {
            Score = new List<HighScore>();
        }

        public int ScorePoints { get; set; }
        public string ScoreName { get; set; }


        public string path = (@"‪C:\Users\db_gb\Google Drive\gladiator save file.txt");
        public string pathHighscore = (@"‪C:\Users\db_gb\Google Drive\gladiatorHighscore file.txt");
        public List<HighScore> Score { get; set; }

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



        public void Highscore()
        {
            //temp lista som bara finns i metoden
            var list = new List<String>();
            ScoreName = "";
            string line = "";
            //impoterar filen och gör om den till strings
            var fileStream = new FileStream(@"‪C:\Users\db_gb\Google Drive\gladiatorHighscore file.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream))
                // lägger till lines i listan
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            //loopar igenom listan och sen plockar ut score och namn ur listan
            foreach (var item in list)
                { 
            ScorePoints = Convert.ToInt32(item.Substring(17, 4));
            ScoreName = item.Substring(item.IndexOf("name:") , item.IndexOf("at")-2);
                //skapar en ny lista med int(score) och sen string (namn) 
                HighScore MakingHighScoreList = new HighScore(ScorePoints, ScoreName);
                MakingHighScoreList.Points = ScorePoints;
                MakingHighScoreList.Name = ScoreName;
                Score.Add(MakingHighScoreList);
            }
            //sorterar listan
            Score.Sort();
            Score.Reverse();
            //lagrar den sorterade listan
            foreach (var item in Score)
            {
                Score.Add(item);
            }
            //printar ut listan
            foreach (var item in Score)
            {
                Console.WriteLine(item);
                Console.WriteLine();
            }
        }


        /*
        public void Import()
        {
            HighScore Hscore = new HighScore();
            //var list = new List<String>();
            List<int , string > listTest = new List<int , string >();


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
            */
    }
}
