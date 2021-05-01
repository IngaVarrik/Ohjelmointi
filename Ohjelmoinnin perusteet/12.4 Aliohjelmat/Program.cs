using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace funktiot
{
    class Program
    {
        private static int Tervehdys(string k)
        {
            Console.WriteLine("Tervetuloa ohjelmaan " + k + "!");
            Console.WriteLine("Anna ikäsi:");
            int i = Convert.ToInt32(Console.ReadLine());
            return i;

        }
        static void Main(string[] args)
        {
            int ika;
            Console.WriteLine("Anna nimesi:");
            string kayttaja = Console.ReadLine();
            ika = Tervehdys(kayttaja);
        }
    }
}