﻿using System;

namespace Tehtävä_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paranna Laske-ohjelmaasi siten, että ohjelma käyttää for-silmukkaa tulostaessaan annetun luvun jakolaskut ja jakojäännösoperaatiot kertotaulun rinnalle.
           
            Console.WriteLine("\nKirjoita numero ");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int a = 1; a <= 10; a++)
            {
                Console.Write(a + " * " + b + " = " + a * b + "   " + a + " / " + b + " = " + a / b + "  " + a + " % " + b + " = " + a % b + "\n");
            }
            Console.ReadKey();
        }
    }
}
