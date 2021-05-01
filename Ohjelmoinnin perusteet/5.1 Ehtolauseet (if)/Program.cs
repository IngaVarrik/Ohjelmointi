
using System;
using System.Globalization;

namespace Tehtävä_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double euroToDollar = 1.19;
            double euroToPound = 0.86;

            Console.WriteLine("Kirjoittaa euromääräinen luku. ");

            double euro = Convert.ToDouble(Console.ReadLine());

            double euroD = euro * euroToDollar;
            double euroP = euro * euroToPound;


            String stringEuroD = euroD.ToString("C", new CultureInfo("en-US"));
            String stringEuroP = euroP.ToString("C", new CultureInfo("en-GB"));

            Console.WriteLine(stringEuroD);
            Console.WriteLine(stringEuroP);

            Console.ReadLine();
        }
    }
}
