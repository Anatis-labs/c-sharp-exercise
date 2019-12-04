using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator_game
{
    class Game_engine
    {
            public Game_engine()
            {

            HeroStrengh = random.Next(10,20);
            HeroVitality = random.Next(10,20);
            Damage = HeroStrengh / 2;
            Hp = HeroVitality;
            //TotalDamageDealt = 0;
                
            Fights = new List<Fight>();
            }

        public int HeroStrengh { get; set; }
        public int HeroVitality { get; set; }
        public int Damage { get; set; }
        public int Hp { get; set; }
        public int MaxAttempts { get; set; }
        public int TotalDamageDealt { get; set; }
        public List<Fight> Fights { get; set; }

        private int { Random random = new Random(); }

        private Fight lastFight = null;

    public void SimulateFight(int strengh, int vitality)
    {
        int damageDealt = strengh / 2;
        int hpHero = vitality- damageTaken;
        TotalDamageDealt += damageDealt;
        HealthLeft = MaxHp - CurretHp;

        Fight strike = new Fight();
        strike.DamageDealt = damageDealt;
        strike.HpHero = hpHero;
        strike.DamageTaken = damageTaken;
        strike.HpEnemy = hpEnemy;

        lastFight = strike;

        Fights.Add(strike);
    }


    public void DisplayFightingStats()
    {
        foreach (var item in Fights)
        {
            Console.WriteLine("Damage dealt: ", item.DamageDealt);
            Console.WriteLine("Heroes hp: ", item.HpHero);
            Console.WriteLine("dmg: ", item.DamageTaken);
            Console.WriteLine("Enemys hp: ", item.HpEnemy);
            Console.WriteLine("------------------------------------");
        }
    }
}