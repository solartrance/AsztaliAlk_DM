using System;

namespace Feladat3
{
    internal class Program
    {
        static int ParatlanDb(int[] tomb)
        {
            int db = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 != 0)
                {
                    db++;
                }
            }

            return db;
        }

        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Legalább egy számot adj meg!");
                return;
            }

            int[] szamok = new int[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                szamok[i] = int.Parse(args[i]);
            }

            Console.Write("Megadott számok: ");

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(szamok[i] + " ");
            }

            Console.WriteLine();

            int paratlanokSzama = ParatlanDb(szamok);

            Console.WriteLine("Páratlan számok száma: " + paratlanokSzama);

            Console.ReadKey();
        }
    }
}