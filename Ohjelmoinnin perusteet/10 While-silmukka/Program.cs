using System;

namespace Tehtävä_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee ohjelma, joka pyytää ja lukee viisi kokonaislukua näppäimistöltä, kirjoittaa ne sopivaan taulukkoon
            //ja lopussa laskee niiden keskiarvon ja tulostaa sen näytölle. Käytä keskiarvon laskennassa foreach-lausetta.

            Console.WriteLine("Anna viisi kokonaislukua näppäimistöltä. ");


            double[] numerot = new double[5];

            for(int i=0; i<5; i++)
            {
                numerot[i] = Convert.ToDouble(Console.ReadLine());
            }
            double numerotYhteensa = 0;
            foreach (double apu in numerot)
            {
                numerotYhteensa = numerotYhteensa + apu;
            }
            double numerotKeskiarvo = 0;
            numerotKeskiarvo = numerotYhteensa / 5;
            Console.WriteLine("Annettujen numeroiden keskiarvo on " + numerotKeskiarvo);
            Console.ReadKey();
        }
        
    }
}
