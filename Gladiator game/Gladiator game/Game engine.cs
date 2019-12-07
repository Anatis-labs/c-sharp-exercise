using System;
using System.Collections.Generic;

namespace Gladiator_game
{
    class Game_engine
    {
        public Game_engine()
        {

            GladiatorDamage = 0;
            TotalStats = new List<Stat>();
            Stats = new List<Stat>();
        }


        //public int OpponentsSlayed { get; set; }
        //kanske använda för att hålla koll på hur många som blivit besegrade.

        public int GladiatorDamage { get; set; }
        public int EnemyDamage { get; set; }
        public int GladiatorDamageTaken { get; set; }
        public int EnemyDamageTaken { get; set; }
        public int GladiatorHp { get; set; }
        public int GladiatorStr { get; set; }
        public int EnemyHp { get; set; }
        public int EnemyStr { get; set; }

        private Stat _stats = null;
        private Stat _Totalstats = null;

        public List<Stat> TotalStats { get; set; }

        public List<Stat> Stats { get; set; }




        private Random random = new Random();

        public void Gladiator()
        {
            GladiatorHp = random.Next(10, 20);
            GladiatorStr = random.Next(8, 15);
        }

        public void Enemy()
        {
            EnemyHp = random.Next(5, GladiatorHp);
            EnemyStr = random.Next(5, GladiatorStr);
        }

        public void DisplayFightingStats()
        {
            foreach (var item in Stats)
            {
                Console.WriteLine("Damage dealt: {0}", item.GladiatorDamage);
                Console.WriteLine("Heroes hp: {0}", item.GladiatorHp);
                Console.WriteLine("dmg: {0}", item.EnemyDamage);
                Console.WriteLine("Enemys hp: {0}", item.EnemyHp);
                Console.WriteLine("------------------------------------");
            }
        }

        public void Combat()
        {
            Boolean loopWinner = true;
            while (loopWinner)
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

                        Stat stats = new Stat(EnemyDamage, EnemyHp, GladiatorDamage, GladiatorHp);
                        stats.EnemyDamage = EnemyDamage;
                        stats.EnemyHp = EnemyHp;
                        stats.GladiatorDamage = GladiatorDamage;
                        stats.GladiatorHp = GladiatorHp;
                        _stats = stats;
                        Stats.Add(stats);

                        DisplayFightingStats();

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    default:
                        break;
                }
                if (GladiatorHp <= 0)
                {
                    Console.WriteLine("Ur warrior have been slain by enemy name ");
                    EnemyHp = 0;
                    loopWinner = false;

                    /*
                    Stat stats = new Stat(GladiatorDamage, GladiatorHp, OpponentsSlayed);
                    stats.TotalOpponentsSlayed++;

                    foreach (var item in Stats)
                    {
                        stats.TotalGladiatorDamage += item.EnemyDamage;
                        stats.TotalGladiatorHp += item.GladiatorHp;
                        stats.TotalOpponentsSlayed += item.TotalOpponentsSlayed;

                        Stats.Add(stats);
                        */
                    //lägga till namnet på den motståndaren som besegrade dig
                }
                if (EnemyHp <= 0)
                {
                    Console.WriteLine("Grats ur warrior won!! ");
                    GladiatorHp = 0;
                    loopWinner = false;
                    // lägga till någon kod som plockar bort ett namn ur listan och skriver ut namnet som att du har besegrat detta namnet.
                }

                /*
                                Stat Totalstats = new Stat(EnemyDamage, EnemyHp, GladiatorDamage, GladiatorHp);
                                Totalstats.TotalOpponentsSlayed = OpponentsSlayed;
                                Totalstats.TotalGladiatorDamage = GladiatorDamage;
                                Totalstats.TotalGladiatorHp = GladiatorHp;
                                _Totalstats = Totalstats;
                                Stats.Add(Totalstats);
                  */
            }
        }






    }
}
