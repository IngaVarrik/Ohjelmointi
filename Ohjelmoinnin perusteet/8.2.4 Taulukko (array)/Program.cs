﻿using System;

namespace Tehtävä_8._2._4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int x;

            Console.WriteLine("Kuinka monta tuotetta lisätään? ");
            x = Convert.ToInt32(Console.ReadLine());

            string[] tuoteNimi = new string[x];
            int[] tuoteLkm = new Int32[x];
            decimal[] tuoteHinta = new decimal[x];

            for (int i = 1; i <= tuoteNimi.Length; i++)
            {

                Console.WriteLine("Anna " + i + ". tuotteen nimi: ");
                tuoteNimi[i - 1] = Console.ReadLine();
                Console.WriteLine("Anna " + i + ". tuotteen lukumäärä: ");
                tuoteLkm[i - 1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Anna " + i + ". tuotteen hinta: ");
                tuoteHinta[i - 1] = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(tuoteNimi[i - 1] + " yhteishinta on" + " " + tuoteLkm[i - 1] * tuoteHinta[i - 1] + "€.");
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
