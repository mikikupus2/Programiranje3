using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenikStudent
{
    class Student : Osnovna
    {
        int broj_casova, ocena_iz_programiranja;
        public int Broj_casova
        {
            get { return broj_casova; }
            set { broj_casova = value; }
        }
        public int Ocena_iz_programiranja
        {
            get { return ocena_iz_programiranja; }
            set { ocena_iz_programiranja = value; }
        }
        public Student(int id, string ime, string prezime, int broj_casova, int ocena_iz_programiranja) : base(id, ime, prezime)
        {
            this.broj_casova = broj_casova;
            this.ocena_iz_programiranja = ocena_iz_programiranja;
        }
    }
}
