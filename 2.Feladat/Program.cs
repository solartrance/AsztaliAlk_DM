using System;

namespace Feladat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Hiba! Pontosan 3 paraméter szükséges.");
                return;
            }

            int szam1 = int.Parse(args[0]);
            string muvelet = args[1];
            int szam2 = int.Parse(args[2]);

            double eredmeny = 0;

            switch (muvelet)
            {
                case "+":
                    eredmeny = szam1 + szam2;
                    break;

                case "-":
                    eredmeny = szam1 - szam2;
                    break;

                case "x":
                    eredmeny = szam1 * szam2;
                    break;

                case "/":
                    eredmeny = (double)szam1 / szam2;
                    break;

                default:
                    Console.WriteLine("Ismeretlen művelet!");
                    return;
            }

            Console.WriteLine($"{szam1} {muvelet} {szam2} = {eredmeny}");
            Console.ReadKey();
        }
    }
}
