﻿
using System;

namespace Exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write((j * i) + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}