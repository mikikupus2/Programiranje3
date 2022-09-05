using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenikStudent
{
    class Ucenik : Osnovna
    {
        double prosek;
        int ocena_iz_programiranja;
        public double Prosek
        {
            get { return prosek; }
            set { prosek = value; }
        }
        public int Ocena_iz_programiranja
        {
            get { return ocena_iz_programiranja; }
            set { ocena_iz_programiranja = value; }
        }
        public Ucenik(int id, string ime, string prezime, double prosek, int ocena_iz_programiranja) : base(id,ime,prezime)
        {
            this.prosek = prosek;
            this.ocena_iz_programiranja = ocena_iz_programiranja;
        }
    }
}
