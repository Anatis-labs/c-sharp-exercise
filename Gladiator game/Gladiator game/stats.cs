using System.Collections.Generic;


namespace GladiatorGame
{
    class Stats
    {

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
