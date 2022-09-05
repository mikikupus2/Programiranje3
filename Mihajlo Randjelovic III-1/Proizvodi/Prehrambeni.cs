using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proizvodi
{
    class Prehrambeni : Proizvod
    {
        DateTime rok_upotrebe;
        public DateTime Rok_upotrebe
        {
            get { return rok_upotrebe; }
            set { rok_upotrebe = value; }
        }
        public override bool Upotrebljiv()
        {
            return !(DateTime.Now >= rok_upotrebe);
        }
        public Prehrambeni(string naziv, double cena, DateTime datum_proizvodnje,DateTime rok_upotrebe) :base(naziv,cena,datum_proizvodnje)
        {
            this.naziv = naziv;
            this.cena = cena;
            this.datum_proizvodnje = datum_proizvodnje;
            this.rok_upotrebe = rok_upotrebe;
        }
    }
}
