using System;

namespace Tehtävä_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string vastaus1;
            string vastaus2;
            string vastaus3;

            Start:
            Console.WriteLine("Paistaako aurinko? Vastaa kyllä = K tai ei = E:  ");
            vastaus1 = Console.ReadLine();

            Console.WriteLine("Sataako? Vastaa kyllä = K tai ei = E:  ");
            vastaus2 = Console.ReadLine();

            Console.WriteLine("Onko lämpötila >0? Vastaa kyllä = K tai ei = E:  ");
            vastaus3 = Console.ReadLine();

            if(vastaus1 == "K" && vastaus2 == "K" && vastaus3 == "K")
                {
                Console.WriteLine("Aurinko paistaa ja vettä sataa taitaa tulla kesä.");
            }

            if (vastaus1 == "E" && vastaus2 == "K" && vastaus3 == "K")
            {
                Console.WriteLine("Syksy saapui lehdet vei tuuli menneessään.");
            }

            if ((vastaus1 == "E" && vastaus2 == "E" && vastaus3 == "K") || (vastaus1 == "K" && vastaus2 == "E" && vastaus3 == "K"))
            {
                Console.WriteLine("Jo joutui armas aika ja suvi suloinen.");
            }

            if ((vastaus1 != "E" && vastaus1 != "K") || (vastaus2 != "E" && vastaus2 != "K") || (vastaus3 != "E" && vastaus3 != "K"))
            {
                Console.WriteLine("Sinun pitää vastata kaikille kysymyksille kyllä = K tai ei = E. Kokeile uudestaan\n");
                goto Start;
            }
            
            if (vastaus1 == "E" && vastaus2 == "E" && vastaus3 == "E")
            {
                Console.WriteLine("On viileä keli.");
            }

            if (vastaus1 != "E" && vastaus2 != "E" && vastaus3 == "E")
            {
                Console.WriteLine("On hyvä päivää tehdä läksyjä.");
            }
            Console.ReadLine();
        }
    }
}
