﻿using System;

namespace Tehtävä_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            try
            {
                Console.WriteLine("Anna jaettavaa numero: ");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Anna jakajaa numero: ");
                b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(a + " / " + b + " = " + a / b);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Virhellinen syöte. " + e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Virhellinen syöte. " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Jako nollalla. " + e.Message);
            }

            finally
            {
                Console.WriteLine("Kiitos ohjelman käytöstä.");
            }

        }
    }
}
