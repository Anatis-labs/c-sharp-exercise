using System;
using System.Collections.Generic;
using System.Text;

namespace Gladiator_game
{
    class Game_engine
    {
        public int GladiatorDamage { get; set; }
        public int EnemyDamage { get; set; }
        public int GladiatorDamageTaken { get; set; }
        public int EnemyDamageTaken { get; set; }
        public int GladiatorHp { get; set; }
        public int GladiatorStr { get; set; }
        public int EnemyHp { get; set; }
        public int EnemyStr { get; set; }

        private Stats _stats = null;


        private List<Stats> Statistics = new List<Stats>();




        private Random random = new Random();

        public void Gladiator()
        {
            GladiatorHp = random.Next(10, 20);
            GladiatorStr = random.Next(10, 20);
        }

        public void Enemy()
        {
            EnemyHp = random.Next(5, GladiatorHp);
            EnemyStr = random.Next(5, GladiatorStr);
        }

        public void Combat()
        {
            // fel definierat måste ändra nu kör den så länge åtminstone 1 av dom e sant
            while (EnemyHp > 0 || GladiatorHp > 0)
            {
                Console.WriteLine("press 1 for Strike");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        GladiatorDamage = GladiatorStr;
                        EnemyDamage = EnemyStr;
                        GladiatorHp -= EnemyDamage;
                        EnemyHp -= GladiatorDamage;
                        
                        
                        // måste döpa om ett par för att det ska fungera
                        // (listan finns definerad på stats taben)
                        /*
                        Stats stats = new Stats();
                        stats.EnemyDamage = enemyDamage;
                        stats.EnemyHp = enemyHp;
                        stats.GladiatorDamage = gladiatorDamage;
                        stats.GladiatorHp = gladiatorHp;
                        _stats = stats;
                        */
                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    default:
                        break;

                }

            }
        }


        //    {
        //        HeroStrengh = random.Next(10, 20);
        //        HeroVitality = random.Next(10, 20);
        //        Damage = HeroStrengh / 2;
        //        Hp = HeroVitality;
        //        //TotalDamageDealt = 0;

        //        Fights = new List<Fight>();
        //    }

        //    public int HeroStrengh { get; set; }
        //    public int HeroVitality { get; set; }
        //    public int Damage { get; set; }
        //    public int Hp { get; set; }
        //    public int MaxAttempts { get; set; }
        //    public int TotalDamageDealt { get; set; }
        //    public List<Fight> Fights { get; set; }

        //    private int { Random random = new Random(); }

        //private Fight lastFight = null;

        //public void SimulateFight(int strengh, int vitality)
        //{
        //    int damageDealt = strengh / 2;
        //    int hpHero = vitality - damageTaken;
        //    TotalDamageDealt += damageDealt;
        //    HealthLeft = MaxHp - CurretHp;

        //    Fight strike = new Fight();
        //    strike.DamageDealt = damageDealt;
        //    strike.HpHero = hpHero;
        //    strike.DamageTaken = damageTaken;
        //    strike.HpEnemy = hpEnemy;

        //    lastFight = strike;

        //    Fights.Add(strike);
    }
}

   