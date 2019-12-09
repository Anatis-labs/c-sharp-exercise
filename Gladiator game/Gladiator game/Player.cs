using System;

// skapa hero och motståndare

namespace GladiatorGame
{
    class Player
    {
        public Player()
        {
        }
        public Player(String name)
        {
            Name = name;
        }



        public String Name { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Strikes { get; set; }
        public int Wins { get; set; }
        public int Strengh { get; set; }
        public int TotalStrikes { get; set; }
        public int TotalDmg { get; set; }



        public int Fist()
        {
            int damage = Strengh / 2;
            return damage;
        }
        public int Kick()
        {
            int damage = Strengh;
            return damage;
        }
        public int KneeStrike()
        {
            int damage = Strengh / 3;
            return damage;
        }

        List<string> enemyNames = new List<string>();

            enemyNames.Add("Cassius Gabinius");
            enemyNames.Add("Marcellus Burrienus");
            enemyNames.Add("Agaza Kingspell");
            enemyNames.Add("Jaenwilliams Pomar");
            enemyNames.Add("Antibar Satanbennett");
            enemyNames.Add("Roberfang O'neilllok");
            enemyNames.Add("Drusprice Rosenker");
            enemyNames.Add("Peaknee Glenalvare");
            enemyNames.Add("Ortiphine Jonefur");
            enemyNames.Add("Willpatterson Graylok");
        


    }
}