﻿using System;

namespace Tehtävä_7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee ohjelma joka tulostaa annetun luvun mukaan lukupyramidin. Joudut käyttämään sisäkkäisiä for silmukoita tehtävässä. Eli tulostetaan jokaiselle riville tulostetaan rivi numeroon asti lukuja. 

            Console.Write("\nKirjoita numero ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAnnettu luku: " + numero);
            Console.WriteLine();

            for (int a = 1; a <= numero; a++)
            {
                for (int c = 1; c <= a; c++)
                {
                    Console.Write(c);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}