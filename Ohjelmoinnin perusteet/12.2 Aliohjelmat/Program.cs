using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace funktiot

{
    class Program
    {
        //Lisää aliohjelmaan parametri esittely eli tyyppi ja muuttujan nimi 
        private static void Tervehdys(string k)
        {
            Console.WriteLine("Tervetuloa ohjelmaan " + k + "!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Anna nimesi:");
            string kayttaja = Console.ReadLine();
            Tervehdys(kayttaja);
        }
    }
}