using System;

namespace Tehtävä_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float centimetersToMeters = 0.01F;
            float centimetersToMails = 0.0000062137F;
            float centimetersToYards = 0.010936132983F;
            float centimetersToInches = 0.393700787402F;

            Console.Write("How tall are you in centimetres? ");

            byte pituus = Convert.ToByte(Console.ReadLine());

            float pituusM = pituus * centimetersToMeters;
            float pituusMail = pituus * centimetersToMails;
            float pituusYards = pituus * centimetersToYards;
            float pituusInches = pituus * centimetersToInches;

            
            string spituusM = pituusM.ToString("0.00");
            string spituusMail = pituusMail.ToString("E02");
            string spituusYards = pituusYards.ToString("0.00");
            string spituusInches = pituusInches.ToString("0.00");


            Console.WriteLine(spituusM + " m");
            Console.WriteLine(spituusMail + " mails");
            Console.WriteLine(spituusYards + " yd");
            Console.WriteLine(spituusInches + " inches");

            Console.ReadLine();
           
        }
    }
}
