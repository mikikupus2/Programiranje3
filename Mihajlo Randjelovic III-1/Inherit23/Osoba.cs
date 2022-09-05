using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit23
{
    public class Osoba
    {
        protected string ime, prezime;
        protected int godinar;
        public Osoba(string ime, string prezime, int god)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godinar = god;
        }
        public virtual void PredstaviSe() //virtual mora da se napise da bi se radio override
        {
            Console.WriteLine("Ja sam " + ime + prezime + "rodjen" + godinar);
        }

    }
}
