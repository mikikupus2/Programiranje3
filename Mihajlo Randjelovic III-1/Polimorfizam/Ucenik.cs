using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizam
{
    class Ucenik : Osoba
    {
        private double prosek;
        public Ucenik(string ime, string prez, double prosek) : base(ime, prez)
        {
            this.prosek = prosek;
        }
        public override string Predstavi_se()
        {
            //return ime + " " + prezime + " " + prosek.ToString();
            return "Ja sam ucenik";
        }
    }
}
