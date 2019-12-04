using System;
using System.Collections.Generic;
using System.Text;

// skapa hero och motståndare

namespace Gladiator_game
{
    class Fighters
    {
        public int GladiatorHp { get; set; }
        public int GladiatorStr { get; set; }
        public int EnemyHp {get; set; }
        public int EnemyStr { get; set; }
         
        private Random random = new Random();
        
        public void Gladiator()
        {
            GladiatorHp =  random.Next(10, 20);
            GladiatorStr = random.Next(10, 20);
        }

        public void Enemy()
        {
            EnemyHp = random.Next(5, GladiatorHp);
            EnemyStr = random.Next(5, GladiatorStr);
        }

    }
}