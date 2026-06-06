using System;

namespace zsuga
{
    internal class Pakli
    {
        private Kartya[] lapok;
        private string jokerSzin;

        public Pakli(int maxLap, string jokerSzin)
        {
            this.jokerSzin = jokerSzin;

            lapok = new Kartya[maxLap];

            Random rnd = new Random();

            for (int i = 0; i < lapok.Length; i++)
            {
                int ertek = rnd.Next(2, 15);

                string szin;

                if (rnd.Next(2) == 0)
                    szin = "piros";
                else
                    szin = "fekete";

                lapok[i] = new Kartya(ertek, szin);
            }
        }

        public Pakli()
        {
            jokerSzin = "fekete";

            lapok = new Kartya[52];

            Random rnd = new Random();

            for (int i = 0; i < lapok.Length; i++)
            {
                int ertek = rnd.Next(2, 15);

                string szin;

                if (rnd.Next(2) == 0)
                    szin = "piros";
                else
                    szin = "fekete";

                lapok[i] = new Kartya(ertek, szin);
            }
        }

        public Kartya GetKartya(int index)
        {
            if (index >= 0 && index < lapok.Length)
                return lapok[index];

            return new Kartya();
        }

        public int GetMaxLap()
        {
            return lapok.Length;
        }

        public void OsszesLap()
        {
            for (int i = 0; i < lapok.Length; i++)
            {
                Console.WriteLine(lapok[i]);
            }
        }

        public override string ToString()
        {
            return lapok.Length + " lapos kartyapakli " +
                   jokerSzin + " joker szinnel";
        }

        public int BlackJackLight(int darab)
        {
            int osszeg = 0;

            if (darab > lapok.Length)
            {
                darab = lapok.Length;
            }

            for (int i = 0; i < darab; i++)
            {
                if (lapok[i].GetSzin() == jokerSzin)
                {
                    osszeg += lapok[i].GetErtek();
                }
                else
                {
                    osszeg += (int)Math.Ceiling(lapok[i].GetErtek() / 2.0);
                }
            }

            return osszeg;
        }

        public int BlackJackLight(Kartya keresettKartya)
        {
            int osszeg = 0;

            for (int i = 0; i < lapok.Length; i++)
            {
                if (lapok[i].GetSzin() == jokerSzin)
                {
                    osszeg += lapok[i].GetErtek();
                }
                else
                {
                    osszeg += (int)Math.Ceiling(lapok[i].GetErtek() / 2.0);
                }

                if (lapok[i].GetSzin() == keresettKartya.GetSzin() &&
                    lapok[i].GetErtek() == keresettKartya.GetErtek())
                {
                    break;
                }
            }

            return osszeg;
        }

        public void EgyszinuPakli()
        {
            for (int i = 0; i < lapok.Length; i++)
            {
                lapok[i].SetSzin(jokerSzin);
            }
        }
    }
}