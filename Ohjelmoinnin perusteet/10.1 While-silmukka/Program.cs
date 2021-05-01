using System;

namespace Tehtävä_10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee ohjelma, joka pyytää ja lukee kokonaislukuja näppäimistöltä, laskee ne yhteen ja näyttää niiden reaaliaikaisen summan samalla,
            //kun se pyytää seuraavaa lukua.Ohjelman pitää jatkaa näin niin kauan kuin lukujen yhteissumma on korkeintaan 100.
            //Jos lukujen yhteissumma ylittää 100, ohjelman tulee ilmoittaa, että raja on saavutettu ja se lopettaa toiminnan.

            Console.WriteLine("Anna kokonaislukuja näppäimistöltä. ");

            int summa = 0;

            while(summa < 100)
            {
                summa = summa + Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(summa);
            }
            Console.ReadLine();
        }
    }
}
