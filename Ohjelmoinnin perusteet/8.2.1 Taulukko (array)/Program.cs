﻿using System;

namespace Tehtävä_8._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] tuotteet = { "Omena", "Ananas", "Kiivi" };

            double[] hinnat = { 0.7, 2.3, 5.1 };

            for (int i = 0; i < 3; i++)

                Console.WriteLine(tuotteet[i] + " " + hinnat[i] + "€");


            Console.ReadKey();
        }
    }
}
