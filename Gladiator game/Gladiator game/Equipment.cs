// skapar rapporter från rundorna

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
            if (rngArmor > 2)
            {
                Console.WriteLine("sorry no armor found this time");
            }
            if (rngArmor <= 4 && rngArmor >= 2)
            {
                Console.WriteLine("grats u found a 2+ armor");
                Armor = 2;
            }
            if (rngArmor == 5)
            {
                Console.WriteLine("Grats u found the jackpot");
                Armor = 4;
            }

        }
        public void WeaponEquipment()
        {
            int rngWeapon = rnd.Next(0, 4);
            if (rngWeapon > 2)
            {
                Console.WriteLine("sorry no armor found this time");
            }
            if (rngWeapon <= 4 && rngWeapon >= 2)
            {
                Console.WriteLine("grats u found a 2+ armor");
                Armor = 2;
            }
            if (rngWeapon == 5)
            {
                Console.WriteLine("Grats u found the jackpot");
                Armor = 4;
            }
        }
    }
}


