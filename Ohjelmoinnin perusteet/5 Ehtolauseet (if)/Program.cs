﻿using System;
using System.Globalization;

namespace Tehtävä_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double euroToDollar = 1.19;
            double euroToPound = 0.86;

            Console.WriteLine("Kirjoitta euromääräinen luku. ");

            double euro = Convert.ToDouble(Console.ReadLine());
            Start:
            Console.WriteLine("Muunnetaanko annettu euromäärä dollareiksi vai punniksi? Kirjoitta dollari tai punta. ");
            String valuutta = Console.ReadLine();


            if (valuutta == "dollari") 
            {
                double euroD = euro * euroToDollar;
                String stringEuroD = euroD.ToString("C", new CultureInfo("en-US"));
                Console.WriteLine(stringEuroD);
                return;
            }

            if(valuutta == "punta")
            {
                double euroP = euro * euroToPound;
                String stringEuroP = euroP.ToString("C", new CultureInfo("en-GB"));
                Console.WriteLine(stringEuroP);
                return;
            }

            goto Start;

            Console.ReadLine();
        }
    }
}
