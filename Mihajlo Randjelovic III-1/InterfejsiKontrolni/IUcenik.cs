using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfejsiKontrolni
{
    interface IUcenik
    {
        double Ime { get; set; }
        double Prezime { get; set; }
        int Ocena { get; set; }
        void Oceni();
        string Izvestaj();
    }
}
