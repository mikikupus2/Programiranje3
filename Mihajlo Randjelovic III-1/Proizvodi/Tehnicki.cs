using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proizvodi
{
    class Tehnicki : Proizvod
    {
        int garancija;
        public int Garancija
        {
            get { return garancija; }
            set { garancija = value; }
        }
        public override bool Upotrebljiv()
        {
            return !((datum_proizvodnje.Year + garancija) >= DateTime.Now.Year);
        }
        public Tehnicki(string naziv, double cena, DateTime datum_proizvodnje, int Garancija) : base(naziv, cena, datum_proizvodnje)
        {
            this.naziv = naziv;
            this.cena = cena;
            this.datum_proizvodnje = datum_proizvodnje;
            this.garancija = garancija;
        }
    }
}
