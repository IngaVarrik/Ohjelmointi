﻿using System;

namespace Tehtävä_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vaihe 1. Toteuta ohjelma, joka kirjoittaa numerot 1-10 jokaisen omalle rivilleen. Käytä toteutuksessa for silmukkaa.
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }

            //Vaihe 2. Toteuta ohjelma niin, että se kysyy aloituslukua käyttäjältä ja tulostaa sen ja seuraavat 9 lukua omille riveilleen.
            int numero;
            Console.WriteLine("\nKirjoita numero ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = numero + 1; i < numero + 9; i++)
            {
                Console.WriteLine(i);
            }

            //Vaihe 3. Toteuta ohjelma niin, että se tulostaa vain joka toisen luvun.
            Console.WriteLine("\nKirjoita numero ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = numero + 1; i < numero + 9; i = i + 2)
            {
                Console.WriteLine(i);
            }

            //Vaihe 4. Toteuta tehtävä niin, että se tulostaa  annetusta luvusta yhden pienempiä lukuja nollaan asti.
            Console.WriteLine("\nKirjoita numero ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = numero - 1; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
