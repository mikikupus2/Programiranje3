using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit23
{
    public class Profesor : Osoba
    {
        private string predmet;
        public Profesor(string ime, string prezime, int god, string predmet) : base(ime, prezime, god)
        {
            this.predmet = predmet;
        }
        public override void PredstaviSe() //override sluzi da moze da se pregazi(prepisuje preko) funkcija iz glavne klase
        {
            base.PredstaviSe();
            Console.WriteLine("Predajem " + predmet);
        }
    }
}
