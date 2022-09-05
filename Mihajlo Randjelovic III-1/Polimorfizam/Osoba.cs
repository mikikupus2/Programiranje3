using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Napisati klasu Osoba koja ima podatke clanove ime i prezime tipa string,metodu predstavi se koja ispisuje "ja sam" + ime + prezime.
iz ove klase izvedena je klasa Ucenik koja ima dodatan podatak clan prosecna ocena tipa double i pregazenu metodu predstavi se koja ispisuje
ime i prezime ucenika i prosecnu ocenu.
Napisati izvedenu klasu Penzioner koja ima dodatan clan starost tipa int i takodje metodu predstavi se koja prikazuje ime i prezime i broj godina(starost).
u glavnom programu  kreirati niz od 10 elementa tipa Osoba i popuniti ih na slucajan nacin objektima metoda klasa Osoba,Ucenik,Penzioner.
Za svaki element niza pozvati metodu PredstaviSe i prikazati rezultat*/
namespace Polimorfizam
{
    class Osoba
    {
        protected string ime;
        protected string prezime;
        public Osoba(string ime, string prez)
        {
            this.ime = ime;
            prezime = prez;
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public virtual string Predstavi_se()
        {
            //return "Ja sam " + ime + " " + prezime;
            return "Ja sam osoba";
        }
    }
}
