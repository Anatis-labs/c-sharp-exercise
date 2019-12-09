using System;
using System.Collections.Generic;

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

        public Player(String name, int str, int vit)
        {
            Name = name;
            Strengh = str;
            Health = vit;
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

        public List<String> EnemyNames = new List<String>();
        public void EnemyNameList()
        {
            EnemyNames.Add("Cassius Gabinius");
            EnemyNames.Add("Marcellus Burrienus");
            EnemyNames.Add("Agaza Kingspell");
            EnemyNames.Add("Jaenwilliams Pomar");
            EnemyNames.Add("Antibar Satanbennett");
            EnemyNames.Add("Roberfang O'neilllok");
            EnemyNames.Add("Drusprice Rosenker");
            EnemyNames.Add("Peaknee Glenalvare");
            EnemyNames.Add("Ortiphine Jonefur");
            EnemyNames.Add("Willpatterson Graylok");
        }
    }
}