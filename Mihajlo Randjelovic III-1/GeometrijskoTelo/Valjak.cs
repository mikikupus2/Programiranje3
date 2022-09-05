using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskoTelo
{
    class Valjak : GTelo
    {
        protected double r;
        protected double h;
        public double R
        {
            get { return r; }
            set { r = value; }
        }
        public double H
        {
            get { return h; }
            set { h = value; }
        }
        public Valjak(double r,double h)
        {
            this.r = r;
            this.h = h;
            RacunajP();
            RacunajV();
        }
        public override void RacunajP()
        {
            p = 2 * (Math.Pow(r, 2) * Math.PI) + 2 * r * Math.PI * h;
        }
        public override void RacunajV()
        {
            v = Math.Pow(r, 2) * Math.PI * h;
        }
    }
}
