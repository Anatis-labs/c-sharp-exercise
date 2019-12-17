using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator_game
{
    class HighScore
    {
        public HighScore(int greger,string greta)
        {
            Points = greger;
            Name = greta;
        }
        //public List<HighScore> Score {get; set;}
       // public List<String> Score {get; set;}
        public int Points { get; set; }
        public string Name { get; set; }
    }
}
