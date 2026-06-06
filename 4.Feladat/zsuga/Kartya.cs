using System;

namespace zsuga
{
    internal class Kartya
    {
        private int ertek;
        private string szin;

        public Kartya(int ertek, string szin)
        {
            if (ertek >= 2 && ertek <= 14)
            {
                this.ertek = ertek;
            }
            else
            {
                this.ertek = 2;
            }

            this.szin = szin;
        }

        public Kartya()
        {
            this.ertek = 0;
            this.szin = "piros";
        }

        public int GetErtek()
        {
            return ertek;
        }

        public void SetErtek(int ertek)
        {
            if (ertek >= 2 && ertek <= 14)
            {
                this.ertek = ertek;
            }
        }

        public string GetSzin()
        {
            return szin;
        }

        public void SetSzin(string szin)
        {
            this.szin = szin;
        }

        public override string ToString()
        {
            return szin + " " + ertek;
        }
    }
}