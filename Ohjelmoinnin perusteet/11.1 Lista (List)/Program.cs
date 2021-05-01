using System;

namespace Tehtävä_11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjoita luokan oppilaiden nimiä. Lopeta painamalla Enter ");

            string nimi = " ";

            System.Collections.Generic.List<string> nimet = new System.Collections.Generic.List<string>();

            while (nimi != "")
            {
                nimi = Console.ReadLine();
                nimet.Add(new string(nimi));
            }
            Console.WriteLine("Oppilaiten nimet ovat: ");
            foreach (string apu in nimet)
            {
                Console.WriteLine(apu);
            }
            Console.ReadKey();
        }
    }
}
