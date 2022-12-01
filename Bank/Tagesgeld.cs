using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Tagesgeld
    {
        private Konto verrechnungsKonto;
        private double guthaben;
        private double zinssatz;

        public Tagesgeld(Konto konto)
        {
            this.verrechnungsKonto = konto;
        }
        public int VerrechnungsKontoNr
        {
            get
            {
                return verrechnungsKonto.KontoNr;
            }
        }

        public double Guthaben
        {
            get
            {
                return guthaben;
            }
        }

        public double Zinssatz
        {
            get
            {
                return this.zinssatz;
            }
            set
            {
                this.zinssatz = value;
            }
        }

        public Konto VerrechnungsKonto
        {
            get
            {
                return this.verrechnungsKonto;
            }
        }

        public void Einzahlen(double betrag)
        {
            this.verrechnungsKonto.Auszahlen(betrag);
            this.guthaben += betrag;
        }
    }
}
