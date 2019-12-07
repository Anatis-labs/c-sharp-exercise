// skapar 

namespace Gladiator_game
{
    class Stat
    {
        public Stat(int enemyDamage, int enemyHp, int gladiatorDamage, int gladiatorHp)
        {
            EnemyHp = enemyHp;
            EnemyDamage = enemyDamage;
            GladiatorDamage = gladiatorDamage;
            GladiatorHp = gladiatorHp;
        }

       

        public int EnemyHp { get; set; }
        public int EnemyDamage { get; set; }
        public int GladiatorDamage { get; set; }
        public int GladiatorHp { get; set; }

        /*
        public Stat(int totalOpponentsSlayed, int totalgladiatorDamage, int totalgladiatorHp)
        {
            TotalOpponentsSlayed = totalOpponentsSlayed;
            TotalGladiatorDamage = totalgladiatorDamage;
            TotalGladiatorHp = totalgladiatorHp;
        }


        public int TotalOpponentsSlayed { get; set; }
        public int TotalGladiatorDamage { get; set; }
        public int TotalGladiatorHp { get; set; }
        */



    }
}