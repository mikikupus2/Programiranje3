using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit23
{
    public class Ucenik : Osoba
    {
        private int razred, odeljenje;
        public Ucenik(string ime, string prezime, int god, int razred, int odeljenje) : base(ime, prezime, god)
        {
            this.razred = razred;
            this.odeljenje = odeljenje;
        }
        public override void PredstaviSe() //override sluzi da moze da se pregazi(prepisuje preko) funkcija iz glavne klase
        {
            base.PredstaviSe();
            Console.WriteLine("Ucenik " + razred + "-" + odeljenje + " razreda");
        }
    }
}
