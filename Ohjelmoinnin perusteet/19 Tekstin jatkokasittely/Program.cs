using System;

namespace _19_Tekstin_jatkokasittely
{
    class Program
    {
        static void Main(string[] args)
        {
            string esimerkki = "{" +
                "opettajat:[" +
                "{ firstName:Jussi, lastName:Torppa }," +
                "{ firstName:Sari, lastName:Paunonen }," +
                "{ firstName:Ville, lastName:Hämäläinen }" +
                "]" +
                "oppilaat:[" +
                "{ firstName:Aku, lastName:Ankka }," +
                "{ firstName:Mikki, lastName:Hiiri }," +
                "{ firstName:Hessu, lastName:Hopo }" +
                "]}";
          esimerkki = esimerkki.Replace("{opettajat:[", "OPETTAJAT:\n");
            esimerkki = esimerkki.Replace("{", "");
            esimerkki = esimerkki.Replace("},", "\n");
            esimerkki = esimerkki.Replace("}]oppilaat:[", "\nOPPILAAT:\n");
            esimerkki = esimerkki.Replace("}]}", "");
            //  esimerkki.Replace("opettajat", "OPETTAJAT");
            for (int i = 0; i < esimerkki.Length; i++)
            {
                string kirjain = esimerkki[i].ToString();
                Console.Write(kirjain);
            }
            Console.ReadKey();
        }
    }
}