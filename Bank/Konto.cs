using System;

namespace Bank
{
    public class Konto
    {
        private int guthaben;
        public static int KontoCounter;
        private int kontoNr;

        public int KontoNr
        {
            get
            {
                return kontoNr;
            }
        }

        public int Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public Konto(int guthaben)
        {
            KontoCounter++;
            kontoNr = KontoCounter;
            if (guthaben < 0)
            {
                throw new ArgumentOutOfRangeException("Das Konto darf nicht mit einem negativen Betrag erstellt werden!");
            }
            else
            {
                this.guthaben = guthaben;
            }
        }

        public void Einzahlen(int betrag)
        {
            guthaben += betrag;
        }

        public void Auszahlen(int betrag)
        {
            if (guthaben >= betrag)
            {
                guthaben -= betrag;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Guthaben nicht ausreichend");
            }
        }
    }
}
