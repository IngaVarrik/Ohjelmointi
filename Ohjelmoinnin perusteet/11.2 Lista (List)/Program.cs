using System;
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

            while (nimi != "")
            {
                nimi = Console.ReadLine();
                nimet.Add(new string(nimi));
            }

            Console.WriteLine("Montako oppilan nimeä haluat nähdä? ");
            int lukumaara;
            lukumaara = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Oppilaiten nimet ovat: ");

            for (int i = 0; i < lukumaara; i++)
            {
                Console.WriteLine(nimet[i]);
            }

            Console.ReadKey();
        }
    }
}