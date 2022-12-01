using System;

namespace Bank
{
    public class Konto
    {
        private double guthaben;
        public static int KontoCounter = 0;
        private int kontoNr;

        public int KontoNr
        {
            get
            {
                return kontoNr;
            }
        }

        public double Guthaben
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

        public void Einzahlen(double betrag)
        {
            guthaben += betrag;
        }

        public void Auszahlen(double betrag)
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
