﻿using System;
using System.Collections.Generic;

namespace Tehtävä_11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Käyttäjä voi valita kuinka monta oppilasta hän haluaa nähdä. 

            Console.WriteLine("Kirjoita luokan oppilaiden nimiä. Lopeta painamalla Enter ");

            string nimi = " ";

            List<string> nimet = new List<string>();

            while (true)
            {
                nimi = Console.ReadLine();
                if (nimi == "")
                    break;
                nimet.Add(new string(nimi));
            }

            Console.WriteLine("Montako oppilan nimeä haluat nähdä? ");
            int lukumaara;
            lukumaara = Convert.ToInt32(Console.ReadLine());

            string aakkosjarjestys;
            Console.WriteLine("Näytetäänkö oppilaat aakkosten a=alkupäästä vai b=loppupäästä? ");
            aakkosjarjestys = Console.ReadLine();
            nimet.Sort();

            if (aakkosjarjestys == "b")
            {
                nimet.Reverse();
            }

            Console.WriteLine("Oppilaiten nimet ovat: ");

            for (int i = 0; i < lukumaara; i++)
            {
                Console.WriteLine(nimet[i]);
            }


            Console.ReadKey();
        }
    }
}