﻿using System;

namespace Tehtävä_10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jatka tehtävää, missä käyttäjä yritti arvata 5 kertaa numeroa 45.
            //Muuta ohjelman toimintaa niin, että käyttäjä voi arvata numeroa niin pitkään, kun arvaa oikean numeron tai hän painaa L -merkkiä.

            Random satluku = new Random();
            int arvonta = satluku.Next(1, 50);
            int numero = 0;
            while (arvonta != numero)
            {
                Console.WriteLine("\nAnna luku näppäimistöltä väliltä 1-50");

                string merkkijono;
                merkkijono = Console.ReadLine();

                if(merkkijono == "L")
                {
                    break;
                }
                numero = Convert.ToInt32(merkkijono);


                Console.WriteLine("\nAnnettu luku: " + numero);
                Console.WriteLine();


                if (arvonta == numero)
                {
                    Console.WriteLine("Onneksi olkoon, sama luku!");
                    Console.ReadKey();
                    return;

                }
            }

            Console.WriteLine("Painoit L, lopetetaan ohjelma.");
            Console.ReadKey();
            return;

        }
    }
}