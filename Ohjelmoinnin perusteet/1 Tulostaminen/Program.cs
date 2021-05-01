


using System;

namespace Hei_Maailma_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Hei Maailma!");
            Console.ReadLine();
            Console.Write("Mikä on sinun nimesi? ");
            String Name = Console.ReadLine();
            Console.Write("Mikä on sinun ikäsi? ");
            string syote = Console.ReadLine();
            int luku = int.Parse(syote);
            Console.WriteLine("Hei " + Name + ", " + luku + "!");


            Console.ReadLine();

        }
    }
}



