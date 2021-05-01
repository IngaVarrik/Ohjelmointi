using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17._1_Vakioluettelo___enumeration
{
    class Program
    {
        enum tiedot
        {
            lisaaNimi = 0, lisaaIka = 1, naytaNimi = 2, naytaIkasi = 3, Poistu
        }
        static void Main(string[] args)
        {
            int tietoa;

            Console.WriteLine("Kirjoitaa arvosanan väliltä (0-3) ");
             tietoa = int.Parse(Console.ReadLine());
            string tulos = "";
            Console.WriteLine("Syötä nimesi: " + tulos);
            Console.WriteLine("Syötä ikäsi: " + tulos);
            Console.WriteLine("Näytä nimesi: " + tulos);
            Console.WriteLine("Näytä ikäsi " + tulos);
            Console.WriteLine("Poistu ohjelmasta.");
            switch (tietoa)
            {
                case 0:
                    tulos = " ";
                    break;
                case 1:
                    tulos = " ";
                    break;
                case 7:
                    tulos = " ";
                    break;
                case 2:
                    tulos = " ";
                    break;
                case 9:
                    tulos = " ";
                    break;
                case 3:
                    tulos = "10 on erinomainen arvosana";
                    break;
                default:
                    Console.WriteLine("Annoit virheellisen arvosanan. Arvosanan pitää olla väliltä (0-3) ");
                    return;
            }
            Console.WriteLine(tulos);
        }
    }
}