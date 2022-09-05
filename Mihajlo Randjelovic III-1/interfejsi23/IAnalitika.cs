using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfejsi23
{
    interface IAnalitika
    {
        double X { get; set; }
        double Y { get; set; }
        double Odstojanje();
        double Rastojanje(double x1, double y1, double x2, double y2);
    }

    interface Ianalitikauravni : IAnalitika, Iaritmetika
    {
        void Crtaj_tacku();
    }

    interface Iaritmetika
    {
        double kvadrat();
    }
}
