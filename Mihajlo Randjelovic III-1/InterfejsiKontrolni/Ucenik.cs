using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfejsiKontrolni
{
    /*
     Dat je interfejs koji ima svojstva
    Ime string
    Prezime string
    Ocena int
    -----
    void Oceni()
    string Izvestaj()
    Klasa koja implementira ovaj interfejs ima podatak clan broj poena tipa int koji se unosi putem konstruktora.
    Napisati Windows Form Aplikaciju
    Klikom na dugme Unos otvara se forma pomocu koje se unose podaci
    Klikom na dugme Oceni poziva se metoda Oceni koja treba da izracuna ocenu na osnovu broja poena tako da je 
    Klikom na izvestaj ipisuje 
    */
    public class Ucenik
    {
        private string ime, prezime;
        private int ocena;
        private int broj_poena;
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
        public int Ocena
        {
            get { return ocena; }
            set { ocena = value; }
        }
        public void Oceni()
        {
            if (broj_poena > 85)
                ocena = 5;
            else if (broj_poena > 70 && broj_poena <= 85)
                ocena = 4;
            else if (broj_poena > 60 && broj_poena <= 70)
                ocena = 3;
            else if (broj_poena > 50 && broj_poena <= 60)
                ocena = 2;
            else
                ocena = 1;
        }
        public string Izvestaj()
        {
            return "Ime: " + ime + Environment.NewLine 
                + "Prezime: " + prezime + Environment.NewLine 
                + "Ocena: " + ocena;
        }
        public Ucenik(string ime, string prezime,int broj_poena)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.broj_poena = broj_poena;
        }
    }
}
