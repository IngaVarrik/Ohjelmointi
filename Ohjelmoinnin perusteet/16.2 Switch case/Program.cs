using System;

namespace Tehtava_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int arvosanat;

            Console.WriteLine("Kirjoitaa arvosanan väliltä (5-10) ");
            arvosanat = int.Parse(Console.ReadLine());
            string tulos;

            switch (arvosanat)
            {
                case 5:
                    tulos = "5 on huono arvosana";
                    break;
                case 6:
                    tulos = "6 on välttävä arvosana";
                    break;
                case 7:
                    tulos = "7 on tyydyttävä arvosana";
                    break;
                case 8:
                    tulos = "8 on hyvä arvosana";
                    break;
                case 9:
                    tulos = "9 on kiitettävä arvosana";
                    break;
                case 10:
                    tulos = "10 on erinomainen arvosana";
                    break;
                default:
                   Console.WriteLine("Annoit virheellisen arvosanan. Arvosanan pitää olla väliltä (5-10) ");
                    return;
            }
            Console.WriteLine(tulos);
        }
    }
}