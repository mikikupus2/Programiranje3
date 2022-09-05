using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TekuciRacun
{
    interface IRacun
    {
        double Stanje { get; set; }
        void Uplata(double iznos);
        void Isplata(double iznos);
    }
}
