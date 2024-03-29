﻿using System;

namespace Tehtävä_8._3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Taulukot voivat olla myös useampi ulotteisia. Tee ohjelmassa alla oleva taulukko kaksiulotteinen string -taulu.
            // Huom. myös luvut täytyy kirjoittaa tekstinä esim. "200".
            // Ohjelma näyttää käyttäjälle Herot ja käyttäjän valinnan mukaan kyseisen heron tiedot, eli Role, Health ja Armor -arvot.

            string[,] Hero = new string[4, 4];

            //HERO
            Hero[0, 0] = "Mech";
            Hero[0, 1] = "Brigitte";
            Hero[0, 2] = "Bastion";
            Hero[0, 3] = "Ana";

            //ROLE
            Hero[1, 0] = "Tank";
            Hero[1, 1] = "Support";
            Hero[1, 2] = "Defence";
            Hero[1, 3] = "Support";

            //HEALTH
            Hero[2, 0] = "400";
            Hero[2, 1] = "200";
            Hero[2, 2] = "200";
            Hero[2, 3] = "200";

            //ARMOR
            Hero[3, 0] = "200";
            Hero[3, 1] = "50";
            Hero[3, 2] = "100";
            Hero[3, 3] = "0";

            string name;
            Console.WriteLine(" Choose the Hero´s name: Mech, Brigitte, Bastion or Ana. ");
            name = Console.ReadLine();
            Console.WriteLine();

            for (int rivi = 0; rivi < 4; rivi++)
            {
                if (name == Hero[0, rivi])
                {
                    Console.WriteLine("Hero´s " + Hero[0, rivi] + ", Role is " + Hero[1, rivi] + ", Health is " + Hero[2, rivi] + ", Armor is " + Hero[3, rivi] + ".");
                }
            }
            Console.ReadLine();
        }
    }
}
