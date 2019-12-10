// skapar rapporter från rundorna
using Players;
using System;

namespace GladiatorGame
{
    public class Equipment
    {
        
        public int Armor { get; set; }
        public int Weapon { get; set; }
        private Random rnd = new Random();


        public void ArmorEquipemnt()
        {
            int rngArmor = rnd.Next(0, 4);
            if (rngArmor < 2)
            {
                Console.WriteLine("sorry no armor found this time");
            }
            if (rngArmor <= 4 && rngArmor >= 2)
            {                
                if (Armor > 2)
                { Console.WriteLine("you already have a better armor than the one you fund, better luck next time"); }
                else
                {
                    Armor = 2;
                    Console.WriteLine("grats u found a +{0} armor", Armor);
                }
            }
            if (rngArmor == 5)
            {
                Console.WriteLine("Grats u found the jackpot");
                Armor = 4;
            }
            Console.WriteLine();
        }

        public void WeaponEquipment()
        {
            int rngWeapon = rnd.Next(0, 4);
            if (rngWeapon < 2)
            {
                Console.WriteLine("sorry no armor found this time");
            }
            if (rngWeapon <= 4 && rngWeapon >= 2)
            {
                if (Weapon == 2)
                { Console.WriteLine("you already have a better armor than the one you fund, better luck next time"); }
                else
                {                   
                    Weapon = 2;
                    Console.WriteLine("grats u found a +{0} armor", Weapon);
                }             
            }
            if (rngWeapon == 5)
            {
                Console.WriteLine("Grats u found the jackpot");
                Weapon = 4;
                Console.WriteLine("You fund a {0}", Weapon);
            }
            Console.WriteLine();
        }
    }
}


