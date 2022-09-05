using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tackev1 //Tackew1
{ 
    class Tacke
    {
        private double x;
        private double y;
        private double d;
        public double D
        {
            get
            { return this.d; }
        }
        public double X
        {
            get
            { return this.x; }
            set
            { this.x = value; }
        }
        public double Y
        {
            get
            { return this.y; }
            set
            { this.y = value; }
        }
        /*
        public Tacka(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        */
        public void Rastojanje()
        {
            this.d = Math.Pow(Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2)), 2) * Math.PI;
        }
    }
}
