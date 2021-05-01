using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace funktiot
{
    class Program
    //Muunna tehtävää 13 (aliohjelmat 2), niin ettei ohjelma kaadu vaikka käyttäjä syöttäisi mitä tahansa. 
    {
        private static int Pienin(int eka, int toka, int kolmas)
        {
            if (eka < toka && eka < kolmas)
                return eka;
            if (toka < eka && toka < kolmas)
                return toka;
            if (kolmas < eka && kolmas < toka)
                return kolmas;
            return 0;
        }
        private static int Suurin(int eka, int toka, int kolmas)
        {
            if (eka > toka && eka > kolmas)
                return eka;
            if (toka > eka && toka > kolmas)
                return toka;
            if (kolmas > eka && kolmas > toka)
                return kolmas;
            return 0;
        }
        static void Main(string[] args)
        {
            int luku1, luku2, luku3, suurinLuku, pieninLuku;
            string syote;
            Console.WriteLine("Anna eka luku:");
            syote = Console.ReadLine();
            bool result = int.TryParse(syote, out luku1);
            if (!result) Console.WriteLine("Annettua merkkijonoa ei voida muuttaa kokonaisluvuksi.");              
            Console.WriteLine("Anna toka luku:");
            syote = Console.ReadLine();
            result = int.TryParse(syote, out luku2);
            if (!result) Console.WriteLine("Annettua merkkijonoa ei voida muuttaa kokonaisluvuksi.");
            Console.WriteLine("Anna kolmas luku:");
            syote = Console.ReadLine();
            result = int.TryParse(syote, out luku3);
            if (!result) Console.WriteLine("Annettua merkkijonoa ei voida muuttaa kokonaisluvuksi.");

            //Kutsu tässä Pienin ja Suurin ohjelmia ja anna niille parametreina luku1, luku2 ja luku3.
            // Ota aliohjelmien tulokset talteen suurinLuku ja pieninLuku muuttujiin. Tulosta lopuksi tulokset 
            pieninLuku = Pienin(luku1, luku2, luku3);
            suurinLuku = Suurin(luku1, luku2, luku3);
            Console.WriteLine("Pienin luku on: " + pieninLuku);
            Console.WriteLine("Suurin luku on: " + suurinLuku);
        }
    }
}