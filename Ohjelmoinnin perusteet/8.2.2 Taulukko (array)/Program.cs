﻿using System;

namespace Tehtävä_8._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] tuoteNimi = { "Omena", "Ananas", "kiivi"};

            int[] tuoteLkm = { 60, 10, 5 };

            decimal[] tuoteHinta = { 0.97M, 3.03M, 3.7M};

            for (int i = 0; i < tuoteNimi.Length; i++)

                Console.WriteLine(tuoteNimi[i] + " yhteishinta on" + " " + tuoteLkm[i] * tuoteHinta[i] + "€.");


            Console.ReadKey();
        }
    }
}
