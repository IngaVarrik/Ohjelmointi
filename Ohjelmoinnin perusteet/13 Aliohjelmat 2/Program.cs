﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace funktiot
{
    class Program
    {
        private static int Pienin(int eka, int toka, int kolmas)
        {
            if (eka < toka && eka < kolmas)
                return eka;
            if (toka < eka && toka < kolmas)
                return toka;
            if (kolmas < eka && kolmas < toka)
                return kolmas;
            return 0;
        }
        private static int Suurin(int eka, int toka, int kolmas)
        {
            if (eka > toka && eka > kolmas)
                return eka;
            if (toka > eka && toka > kolmas)
                return toka;
            if (kolmas > eka && kolmas > toka)
                return kolmas;
            return 0;
        }
        static void Main(string[] args)
        {
            int luku1, luku2, luku3, suurinLuku, pieninLuku;
            string syote;
            Console.WriteLine("Anna eka luku:");
            syote = Console.ReadLine();
            luku1 = int.Parse(syote);
            Console.WriteLine("Anna toka luku:");
            syote = Console.ReadLine();
            luku2 = int.Parse(syote);
            Console.WriteLine("Anna kolmas luku:");
            syote = Console.ReadLine();
            luku3 = int.Parse(syote);
            //Kutsu tässä Pienin ja Suurin ohjelmia ja anna niille parametreina luku1, luku2 ja luku3.
            // Ota aliohjelmien tulokset talteen suurinLuku ja pieninLuku muuttujiin. Tulosta lopuksi tulokset 
            pieninLuku = Pienin(luku1, luku2, luku3);
            suurinLuku = Suurin(luku1, luku2, luku3);
            Console.WriteLine("Pienin luku on: " + pieninLuku);
            Console.WriteLine("Suurin luku on: " + suurinLuku);
        }
    }
}