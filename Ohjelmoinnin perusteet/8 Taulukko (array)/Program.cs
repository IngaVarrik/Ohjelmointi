﻿using System;

namespace Tehtävä_8._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee ohjelma johon tallennat kolme hedelmää taulukkoon. Tulosta lopuksi taulukon sisältö.

            string[] hedelmät = { "kiivi", "banaani", "ananas" };
            foreach (string i in hedelmät)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
