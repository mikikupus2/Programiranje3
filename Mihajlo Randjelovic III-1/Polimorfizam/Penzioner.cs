using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    class Penzioner : Osoba
    {
        private int starost;
        public Penzioner(string ime, string prezime, int starost) : base(ime, prezime)
        {
            this.starost = starost;
        }
        public override string Predstavi_se()
        {
            //return ime + " " + prezime + " " + starost.ToString();
            return "Ja sam penzioner";
        }
    }
}
