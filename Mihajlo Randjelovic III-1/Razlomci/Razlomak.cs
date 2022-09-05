using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Napisati klasu Razlomak koja ima podatke clanove imenilac i brojilac celi brojevi, 
konstruktor preko koga se zadaju vrednosti podataka i preklopljene operatore jednakosti i mnozenja*/
namespace Razlomci
{
    class Razlomak
    {
        private int imenilac;
        private int brojilac;
        public Razlomak(int imenilac, int brojilac)
        {
            this.imenilac = imenilac;
            this.brojilac = brojilac;
        }
        public static bool operator ==(Razlomak levi, Razlomak desni)
        {
            if (levi.imenilac == desni.imenilac && levi.brojilac == desni.brojilac)
                return true;
            else
                return false;
        }
        public static bool operator !=(Razlomak levi, Razlomak desni)
        {
            return !(levi == desni);
        }
        public static Razlomak operator *(Razlomak levi, Razlomak desni)
        {
            return new Razlomak(levi.imenilac * desni.imenilac, levi.brojilac * desni.brojilac);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Razlomak))
                return false;
            else
                return this == (Razlomak)obj;
        }
        public string IspisiImenilac()
        {
            return this.imenilac.ToString();
        }
        public string IspisiBrojilac()
        {
            return this.brojilac.ToString();
        }
    }
}
