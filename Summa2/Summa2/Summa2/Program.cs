﻿using System;
namespace Summa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna x:lle arvo: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna y:lle arvo: ");
            int y = int.Parse(Console.ReadLine());

            int summa2 = x += y;
            Console.WriteLine("x = " + summa2);
        }
    }
}