using System;

namespace _21._Nopanheitto
{
    class Program
    {
        static void Main(string[] args)
        {
           // Ohjelmassa kahden nopan heittäminen suoritetaan käyttäjän valitsema määrä kertoja ja lopuksi tulostetaan kaikkien heittojen yhteenlaskettu summa.
           // Käytä for-toistorakennetta.Käytä silmäluvun arpomiseen C#:n Random-luokkaa.
           
            Console.WriteLine("Tervetuloa nopanheitto ohjelmaan!");
            Console.WriteLine("Ohjelmassa kahden nopan heittäminen suoritetaan viisi kertaa \nja lopuksi tulostetaan kaikkien heittojen yhteenlaskettu summa.\n");

            Random rnd = new Random();

            int laskelma = 0;
            int kierros = 0;
            Console.WriteLine("Valitse heitettävien kierrosten lukumäärä.");
            kierros = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kierros; i++)
            {                
                int dice = rnd.Next(1, 7);
                
                int dice2 = rnd.Next(1, 7);

                int dice3 = rnd.Next(1, 7);

                Console.WriteLine(dice + " ja " + dice2 + " ja " + dice3);
                laskelma = laskelma + dice + dice2 + dice3;
            }
            Console.WriteLine("\nKaikkien heittojen yhteenlaskettu summa on: " + laskelma);
        }
    }
}
