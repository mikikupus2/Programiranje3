using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskoTelo
{
    class Lopta : GTelo
    {
        protected double r;
        public double R
        {
            get { return r; }
            set { r = value; }
        }
        public Lopta(double r)
        {
            this.r = r;
            RacunajP();
            RacunajV();
        }
        public override void RacunajP()
        {
            p = 4 * Math.Pow(r,2) * Math.PI;
        }
        public override void RacunajV()
        {
            v = (4/3) * Math.Pow(r,3) * Math.PI;
        }
    }
}
