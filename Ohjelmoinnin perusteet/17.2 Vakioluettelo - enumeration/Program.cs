using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17._2_Vakioluettelo___enumeration
{
    class Program
    {
        //Vaihe 1. Tee ohjelma, jossa määrittelet vakioluettelon(enumeration) käyttöliittymän valinnoista siten,
        //että lisaaNimi = 0, lisaaIka = 1, naytaNimi = 2, jne.
        //Vaihe 2.Ohjelma kysyy käyttäjältä iän sijasta syntymäpäivän ja laskee iän ja ilmoittaa sen.
        //Lue pvm koneen kellosta. Hyödynnä DateTime luokkaa. Muista että 17,9 vuotias ei ole 18 vuotta!

        enum Valinta
        {
            lisaaNimi = 1, lisaaSpaiva = 2, naytaNimi = 3, naytaIkasi = 4, poistu = 5
        }
        static void Main(string[] args)
        {
            Valinta valinta;
            Console.WriteLine("Tervetuloa ohjelmaan. Siirry valikossa valitsemalla numero.");
            Console.WriteLine("Valinnat ovat:");
            Console.WriteLine("1 Syötä nimesi");
            Console.WriteLine("2 Syötä syntymäpäiväsi muodossa pp/kk/vv");
            Console.WriteLine("3 Näytä nimesi");
            Console.WriteLine("4 Näytä ikäsi");
            Console.WriteLine("5 Poistu ohjelmasta.");
            Console.WriteLine("");
            string nimi = "";
            string sAikaString = "";
            int ika = 0;
            while (true)
            {
                Console.Write(">");
                valinta = (Valinta)Convert.ToInt32(Console.ReadLine());
                switch (valinta)
                {
                    case Valinta.lisaaNimi:
                        Console.WriteLine("Syötä nimesi: ");
                        nimi = Console.ReadLine();
                        Console.WriteLine("Nimesi on tallennettu. ");
                        break;
                    case Valinta.lisaaSpaiva:
                        Console.WriteLine("2 Syötä syntymäpäiväsi muodossa pp/kk/vv");
                        sAikaString = Console.ReadLine();
                        DateTime sAika = DateTime.Parse(sAikaString,
                                      System.Globalization.CultureInfo.CurrentCulture);
                        ika = CalculateAge(sAika, DateTime.Today);

                        Console.WriteLine("Ikäsi: " + ika +" on tallennettu. ");
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

        private static int CalculateAge(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                age--;

            return age;
        }

    }
}