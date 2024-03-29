﻿using System;
using System.Collections.Generic;
using System.Text;
using GladiatorGame;

//I denna uppgift ska du skapa ett gladiatorspel, där hjälten slåss mot x antal motståndare, tills han blir besegrad.
//Följande funktioanlitet ska finnas med:
//  - Hjälten ska skapas med ett namn som användaren bestämmer vid programstart(inte hårdkodad). Övriga värden, som styrka(strength) och liv(health) ska slumpas fram
//  - Motståndarna ska också skapas med slumpmässiga värden för styrka och liv, dock på ett sätt som gör de underlägsna vår krigare, i alla fall i början.
//  - Användaren ska välja via menysystem när en ny runda ska börja.Rundan varar så länge en av partena fortfarande har liv kvar.
//  - Om hjälten besegras ska en rapport skapas över alla motståndare han vunnit över och antal poäng (100 poäng för level 1 motståndare, 200 poäng för level 2, osv).
//  - Måtständarna ska öka i svårighetsgrad var tredje runda.Hitta lämplig mekanism att implementera detta.
//  - Hjälten healar sig för 1 liv mellan varje runda med en ny motståndare.
//  - När en motständare besegras ska hjälten ibland kunna hitta följande: pengar (i förm av mer poäng), eler ett magisk föremål som höjer hjältens liv, styrka, eller båda attributen på samma gång
//   T.ex.helm of vitality (ökar livet med 2 enheter), chestpiece of strength(ökar styrkan med 3 enheter).
//  - Man ska kunna se mellan varje runda, vilka prylar som hjälten samlat på sig, via ett menyalternativ(Inventory). Det ska bara finnas 1 av varje, dvs vår hjälte kan inte ha 2 hjälmar på sig samtidigt.
//   Strength prylar byter ut vitality prylar automatiskt, när dessa "hittas", och ifall värdet är högre än föregående värde
//  - Skapa en rapport i en textfil över besegrade motståndare.

namespace GladiatorGame
{
    class Game
    {
        static void Main(String[] args)
        {
            Random rnd = new Random();
            Boolean loop = true;

            Report save = new Report();
            player Enemys = new player();
            Statistics S = new Statistics();
            Equipment items = new Equipment();
            Slaughter Slaughter = new Slaughter();

            int choice = 0;
            int MinValueHealth = 10;
            int MaxValueHealth = 20;
            int MinValueStrength = 5;
            int MaxValueStrength = 10;
            items.UsedArmor = false;
            items.UsedWeapon = false;

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("--------------- Welcome to the arena!! ---------------");
            Console.WriteLine("The challangers fights untill death, ppl place ur bets");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("---------------- Welcome to the game! ---------------- ");
            Console.Write("Please enter your name: ");

            string name = Console.ReadLine();

            Console.WriteLine($"Welcome {name}, lets see how strong you are today");
            Console.WriteLine("------------------------------------------------------");

            //Create Gladiator 
            player Gladiator = new player(name, rnd.Next(MinValueHealth, MaxValueHealth), rnd.Next(MinValueStrength, MaxValueStrength), 0, 0, 0);

            Gladiator.EnemyNamelist();
            Enemys.Round = 1;       //start counting rounds on 1
            Gladiator.Advantage = 2;
            while (loop)
            {
                Console.WriteLine();

                if (Gladiator.EnemyNames.Count <= 0)    //if enemylist is empty end game
                {                                   // Show stats!!!!
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine($"All Opponents has been beaten. You are the champion!!!!");
                    Console.WriteLine("------------------------------------------------------");
                    Console.WriteLine("----------- Game created by Daniel & Risto -----------");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to quit");
                    Console.ReadKey();
                    break;      //break out of the game
                }

                if (Enemys.Round == 4)
                {
                    Gladiator.Advantage--;
                }
                else if (Enemys.Round == 7)
                {
                    Gladiator.Advantage--;
                }
                int MaxHealthEnemy = Gladiator.Health - Gladiator.Advantage;
                int MaxStrengthEnemy = Gladiator.Strenght - Gladiator.Advantage;

                if (Gladiator.Health - Gladiator.Advantage < MinValueHealth)
                {
                    MaxHealthEnemy = MinValueHealth + 1;
                }
                if (Gladiator.Strenght - Gladiator.Advantage < MinValueStrength)
                {
                    MaxStrengthEnemy = MinValueStrength + 1;
                }

                player Opponent = new player(Gladiator.EnemyNames[0], rnd.Next(MinValueHealth, MaxHealthEnemy), rnd.Next(MinValueStrength, MaxStrengthEnemy), 0, 0, 0);     //Generate new opponent for each fight

                Console.WriteLine();
                if (S.Points == 0 && Enemys.Round == 1)
                {
                    Console.WriteLine("You have not earned any points yet! Start playing.");
                }
                else
                {
                    Console.WriteLine($"Have earned {S.Points} points");

                }
                Console.WriteLine($"Your health is: {Gladiator.Health}\tYour Strenght is: {Gladiator.Strenght}");
                Console.WriteLine();
                Console.WriteLine("Now where do we wanna send the gladiator??");
                Console.WriteLine("------------------------------------------------------");

                Console.WriteLine("Choise 1: Enter the arena and fight untill death");
                Console.WriteLine("Choise 2: Check stats from all fight");
                Console.WriteLine("Choise 3: Enemy list");
                Console.WriteLine("Choise 4: Statistics");
                Console.WriteLine("Choise 5: Armors and Weapons COMING SOON!!!");
                Console.WriteLine("choise 6: Save highscore");
                Console.WriteLine("choise 7: Show highscore");
                Console.WriteLine("Choise 9: Exit the game, and save enemys slayed");
                Console.WriteLine("------------------------------------------------------");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    //uses default in switch                
                }

                switch (choice)
                {
                    case 1:
                        _ = new GameEngine(Gladiator, Opponent, Enemys, S, items, Slaughter);
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine($"Rounds played: {Enemys.Round - 1} ");       // for displaying correct amount of rounds
                        Console.WriteLine();
                        Console.WriteLine($"Gladiator wins: {Gladiator.Wins}");
                        Console.WriteLine($"Damage dealt by gladiator {Gladiator.TotalDmg}");
                        Console.WriteLine();
                        Console.WriteLine($"Opponent wins: {Enemys.Wins}");
                        Console.WriteLine($"Damage dealt by opponent {Enemys.TotalDmg}");
                        break;

                    case 3:
                        int count = 0;
                        Console.WriteLine();
                        Console.WriteLine($"Enemys slaughtered: {Slaughter.Slaughtered.Count}");
                        foreach (var item in Slaughter.Slaughtered)
                        {
                            Console.WriteLine(item);
                            count++;
                        }

                        int level = count;





                        Console.WriteLine();
                        Console.WriteLine($"Enemys left: {Gladiator.EnemyNames.Count}");
                        foreach (var item in Gladiator.EnemyNames)
                        {
                            if (count < 3 || level == 0)
                            {
                                Console.WriteLine("Level 1: ");
                                //count = 3;
                            }
                            if (count >= 3 && count < 5 || level == 3)
                            {
                                Console.WriteLine("Level 2: ");
                                //count = 6;
                            }
                            if (count >= 6 && count < 9 || level == 6)
                            {
                                Console.WriteLine("Level 3: ");
                                //count = 9;
                            }
                            if (count > 9 || level == 9)
                            {
                                Console.WriteLine("Final boss: ");
                                //count = 10;
                            }
                            Console.WriteLine(item);
                            count = 10;
                            level++;
                        }
                        count = 0;
                        break;

                    case 4:
                        S.DisplayStat();
                        break;
                    case 5:
                        items.Display_A_W(Gladiator);
                        break;
                    case 6:
                        save.SaveScore(Gladiator.Name, S.Points);

                        break;
                    case 7:
                        save.Highscore();

                        break;
                    case 9:
                        save.SaveStats(Gladiator.Name, S.Points, Slaughter.Slaughtered);

                        loop = false;
                        break;

                    default:
                        Console.WriteLine("You must choose a number between 1 - 5 or 9!");
                        break;

                }
            }
        }
    }
}