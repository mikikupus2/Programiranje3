using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatMenjacnica
{
    interface IDevize
    {
        double ProdajniKurs { get; set; }
        double KupovniKurs { get; set; }
        void Kupovina(double iznos);
        void Prodaja(double iznos);
        string Stanje();
    }
}
