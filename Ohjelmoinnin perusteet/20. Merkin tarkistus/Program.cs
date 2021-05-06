using System;

namespace _20._Merkin_tarkistus
{
    class Program
    {
        static void Main(string[] args)
        {
            

            while (true)
            {
                Console.WriteLine("Anna merkki. ");
                ConsoleKeyInfo keyinfo = Console.ReadKey();
                char merkki = keyinfo.KeyChar;

                bool a = char.IsWhiteSpace(merkki);
                if (a == true) Console.WriteLine("Annoit tyhjän merkin.");

                bool b = char.IsNumber(merkki);
                if (b == true) Console.WriteLine("\nSyötit numeron " + merkki);

                bool c = char.IsUpper(merkki);
                if (c == true) Console.WriteLine("\nSyötit ison kirjaimen.");

                bool e = char.IsLower(merkki);
                if (e == true) Console.WriteLine("\nSyötit pienen kirjaimen.");

                bool f = char.IsPunctuation(merkki);
                if (f == true) Console.WriteLine("\nSyötit  erikoismerkin, eli jokin muu kuin numero tai kirjain.");

               
            }
        }
    }
}
