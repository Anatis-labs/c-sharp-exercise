using System.Collections.Generic;
using System;
using System.Text;

namespace GladiatorGame
{
    class Stats
    {
        public Stats() { }
        //int enemyDamage, int enemyHp, int gladiatorDamage, int gladiatorHp
        public Stats(int rounds, int totalStrikes, int totalDamage)
        {
            Rounds = rounds;
            TotalStrikes = totalStrikes;
            TotalDamage = totalDamage;
            //OpponentsBeat = gladiatorDamage;
        }

        public int Rounds { get; set; }
        public int TotalDamage { get; set; }
        public int TotalStrikes { get; set; }
        //public int OpponentsBeat { get; set; }


    }
}
