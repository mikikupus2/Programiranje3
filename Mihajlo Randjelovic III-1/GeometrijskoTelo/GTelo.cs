using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Definisati baznu klasu GTelo koja ima podatke clanove povrsina i zapremina tipa double i metode izracunaj p i izracunaj v.Operator >= je preklopljen tako da
je rezultat True ako je zapremina tela koje je argument 1 veca od zapremine tela argument dva u suprotnom je false.Iz ove klase izvedena je 
klasa Lopta koja ima dodatni podatak clan poluprecnik tipa double i pregazene metode racunaj p i racunaj v.I iz klase GTelo izvedena klasa Valjak koja ima dodatne clanove
poluprecnik osnove i visina i u njoj pregazene metode racunaj p i racunaj v.

GTelo ima podrazumevani konstruktor
Lopta R se prenose
Valjak R i H se prenose

u fazi dizajna na formu postaviti teksto boksove za unos vrednosti r i h inicijalno im postaviti vrednost na nula.
Klikom na komandno dugme generise se objekat i to ukoliko je h = 0 lopta, ukoliko su obe dimenzije unete Valjak. i smesta u niz objekata(maksimalno 50).
U listboxu za svaki objekat iz niza ispisati njegov tip i njegovu zapreminu.
postaviti na formu grupu od dva radio dugmeta za izbor vrste geometrijskog tela Valjak ili Lopta i jos jedno komandno dugme cijim klikom se ispisuje u labeli
informacija o najvecem telu odgovarajuce vrste.
*/
//Mihajlo Randjelovic III-1
namespace GeometrijskoTelo
{
    class GTelo
    {
        protected double p;
        protected double v;
        public double P
        {
            get { return p; }
            set { p = value; }
        }
        public double V
        {
            get { return v; }
            set { v = value; }
        }
        public static bool operator >=(GTelo arg1, GTelo arg2)
        {
            if (arg1.v >= arg2.v)
                return true;
            else
                return false;
        }
        public static bool operator <=(GTelo arg1, GTelo arg2)
        {
            if (arg1.v <= arg2.v)
                return true;
            else
                return false;
        }
        public virtual void RacunajP()
        {
            return;
        }
        public virtual void RacunajV()
        {
            return;
        }
    }
}
