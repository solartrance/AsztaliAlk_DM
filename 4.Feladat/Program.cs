using System;
using zsuga;

namespace Feladat4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("Pontosan 2 paraméter szükséges!");
                return;
            }

            int pakliMeret = int.Parse(args[0]);
            int nezendoLapok = int.Parse(args[1]);

            Pakli pakli;

            if (pakliMeret > 0)
            {
                pakli = new Pakli(pakliMeret, "fekete");
            }
            else
            {
                pakli = new Pakli();
            }

            Console.WriteLine("A pakli:");

            pakli.OsszesLap();

            Console.WriteLine();

            int eredmeny = pakli.BlackJackLight(nezendoLapok);

            Console.WriteLine("BlackJackLight eredmény: " + eredmeny);

            Console.ReadKey();
        }
    }
}