using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proizvodi
{
    class Proizvod
    {
        protected string naziv;
        protected double cena;
        protected DateTime datum_proizvodnje;
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        public double Cena
        {
            get { return cena; }
            set { cena = value; }
        }
        public DateTime Datum_proizvodnje
        {
            get { return datum_proizvodnje; }
            set { datum_proizvodnje = value; }
        }
        public Proizvod(string naziv, double cena, DateTime datum_proizvodnje)
        {
            this.naziv = naziv;
            this.cena = cena;
            this.datum_proizvodnje = datum_proizvodnje;
        }
        public virtual bool Upotrebljiv()
        {
            return true;
        }
        public static bool operator ==(Proizvod arg1, Proizvod arg2)
        {
            return (arg1.datum_proizvodnje == arg2.datum_proizvodnje);
        }
        public static bool operator !=(Proizvod arg1, Proizvod arg2)
        {
            return !(arg1.datum_proizvodnje == arg2.datum_proizvodnje);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Proizvod))
                return false;
            else
                return this == (Proizvod)obj;
        }
    }
}

