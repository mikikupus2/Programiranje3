using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Definisati interfejs IRacun koji sadrzi svojstvo Stanje realan broj, Uplata, Isplata koje imaju jedan argument realan broj, a tip rezultata je void.
Napisati klasu TRacun koja implementira prethodni interfejs,metode uplata i isplata direktno menjaju vrednost podatka clana klase koji predstavlja stanje na racunu
Priliko isplate na racunu mora ostati najmanje 100 dinara
Napraviti Windows Aplikaciju(Program) koja na glavnoj(startnoj) formi ima teksboks i tri komandna dugmeta 
Uplata(klikom na dugme otvara se forma na koji treba biti tekstbox za unos i dugme za okoncanje operacije, Isplata, 
Stanje(klikom na dugme stanje prikazuje se stanje u tekstboksu)
Kad se pokrene program stanje na racunu je 1000 din*/
namespace TekuciRacun
{
    public class TRacun : IRacun
    {
        double stanje;
        public double Stanje
        {
            get { return stanje; }
            set { stanje = value; }
        }
        public void Uplata(double iznos)
        {
            Stanje = Stanje + iznos;
        }
        public void Isplata(double iznos)
        {
            Stanje = Stanje - iznos;
        }
    }
}
