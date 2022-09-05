using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfejsi23
{
    class Analiticka : IAnalitika, Iaritmetika
    {
        private double x;
        private double y;
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Odstojanje()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public double Rastojanje(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }
        public double kvadrat()
        {
            return X * X;
        }
    }
}
