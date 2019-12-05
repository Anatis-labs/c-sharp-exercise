using System;
using System.Collections.Generic;

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
                if (GladiatorHp <= 0)
                {
                    Console.WriteLine("Grats u won");
                    GladiatorHp = 0;
                    loopWinner = false;
                    // lägga till någon kod som plockar bort ett namn ur listan och skriver ut namnet som att du har besegrat detta namnet.
                }
                if (EnemyHp <= 0)
                {
                    Console.WriteLine("Ur warrior have been slain");
                    EnemyHp = 0;
                    loopWinner = false;
                }
            }
        }



    }
}