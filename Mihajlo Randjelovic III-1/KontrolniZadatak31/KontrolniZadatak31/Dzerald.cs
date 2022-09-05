using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolniZadatak31
{
    public class Dzerald
    {
        int sifra;
        string ime, prezime, valuta;
        double iznos;
        public int Sifra
        {
            get { return sifra; }
            set { sifra = value; }
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
        public string Valuta
        {
            get { return valuta; }
            set { valuta = value; }
        }
        public double Iznos
        {
            get { return iznos; }
            set { iznos = value; }
        }
        public Dzerald()
        {
        }
    }
}
