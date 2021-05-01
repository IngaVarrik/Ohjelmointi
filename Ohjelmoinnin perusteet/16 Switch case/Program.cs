using System;

namespace Tehtava_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int weekday;
            string day = "";
            bool kysyUudestaan = true;
            while (kysyUudestaan)
            {
                kysyUudestaan = false;
                Console.WriteLine("Kirjoitaa viikonpäivän numero (1-7) ");
                weekday = int.Parse(Console.ReadLine());
                switch (weekday)
                {
                    case 1:
                        day = "maanantai";
                        break;
                    case 2:
                        day = "tiistai";
                        break;
                    case 3:
                        day = "keskkiviikko";
                        break;
                    case 4:
                        day = "torstai";
                        break;
                    case 5:
                        day = "perjantai";
                        break;
                    case 6:
                        day = "lauantai";
                        break;
                    case 7:
                        day = "sunnuntai";
                        break;
                    default:
                        kysyUudestaan = true;
                        Console.WriteLine("Numeron pitää olla väliltä (1-7) ");
                        break;
                }
            }
            Console.WriteLine(day);
        }
    }
}
