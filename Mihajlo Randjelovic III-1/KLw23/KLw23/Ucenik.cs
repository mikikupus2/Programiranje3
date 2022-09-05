using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLw23
{
    class Ucenik
    {
        private int id;
        private string ime;
        private int razred;
        private double prosek;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Razred
        {
            get { return razred; }
            set { razred = value; }
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public double Prosek
        {
            get { return prosek; }
            set { prosek = value; }
        }
        public Ucenik(int id, string ime, int razred, double prosek)
        {
            this.id = id;
            this.ime = ime;
            this.razred = razred;
            this.prosek = prosek;
        }
    }
}
