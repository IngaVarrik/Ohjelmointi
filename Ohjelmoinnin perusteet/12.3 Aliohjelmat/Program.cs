﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace funktiot

{

    class Program

    {

        //Lisää aliohjelmaan parametri esittely eli tyyppi ja muuttujan nimi 

        private static void Tervehdys(string nimi, string sukunimi)

        {
            Console.WriteLine("Tervetuloa ohjelmaan " + nimi + " " + sukunimi + "!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Anna nimesi:");
            string kayttaja = Console.ReadLine();
            Console.WriteLine("Anna sukunimesi:");
            string suku = Console.ReadLine();
            Tervehdys(kayttaja, suku);
        }
    }
}