using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17._1_Vakioluettelo___enumeration
{
    class Program
    {
        //Vaihe 1. Tee ohjelma, jossa määrittelet vakioluettelon(enumeration) käyttöliittymän valinnoista siten,
        //että lisaaNimi = 0, lisaaIka = 1, naytaNimi = 2, jne.  
        enum Valinta
        {
            lisaaNimi = 1, lisaaIka = 2, naytaNimi = 3, naytaIkasi = 4, poistu = 5
        }
        static void Main(string[] args)
        {

            Valinta valinta;


         

            Console.WriteLine("Tervetuloa ohjelmaan. Siirry valikossa valitsemalla numero.");
            Console.WriteLine("Valinnat ovat:");
            Console.WriteLine("1 Syötä nimesi");
            Console.WriteLine("2 Syötä ikäsi");
            Console.WriteLine("3 Näytä nimesi");
            Console.WriteLine("4 Näytä ikäsi");
            Console.WriteLine("5 Poistu ohjelmasta.");
            Console.WriteLine("");
            string nimi = "";
            string ika = "";
            while (true)
            {
                //Console.Write("Valitse numero.");
                Console.Write(">");
                valinta = (Valinta)Convert.ToInt32(Console.ReadLine());
                switch (valinta)
                {
                    case Valinta.lisaaNimi:
                        Console.WriteLine("Syötä nimesi: ");
                        nimi = Console.ReadLine();
                        Console.WriteLine("Nimesi on tallennettu. ");
                        break;
                    case Valinta.lisaaIka:
                        Console.WriteLine("Syötä ikäsi: ");
                        ika = Console.ReadLine();
                        Console.WriteLine("Ikäsi on tallennettu. ");
                        break;
                    case Valinta.naytaNimi:
                        Console.WriteLine("Nimesi on: " + nimi);
                        break;
                    case Valinta.naytaIkasi:
                        Console.WriteLine("Ikäsi on: " + ika);
                        break;
                    case Valinta.poistu:
                        Console.WriteLine("Kiitos ohjelman käytöstä.");
                        return;
                    default:
                        Console.WriteLine("Annoit virheellisen syötteen. Valinnan pitää olla väliltä (1-5) ");
                        return;
                }
            }
        }
    }
}