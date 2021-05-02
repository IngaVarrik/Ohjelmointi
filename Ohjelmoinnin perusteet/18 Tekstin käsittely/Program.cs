using System;

namespace _18_Tekstin_käsittely
{
    class Program
    {
        static void Main(string[] args)
        {
            string merkkijono;
            Console.WriteLine("Anna näppäimistöltä merkkijono: ");
            merkkijono = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(merkkijono);

            char[] array = merkkijono.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {
                // Get character from array. 
                char letter = array[i];
                // Display each letter. 
                Console.Write(letter);
                Console.Write(" ");
            }
            Console.WriteLine();
            for (int i = array.Length-1; i >= 0; i--)
            {
                // Get character from array. 
                char letter = array[i];
                // Display each letter. 
                Console.Write(letter);
            }
            Console.WriteLine();
        }
    }
}