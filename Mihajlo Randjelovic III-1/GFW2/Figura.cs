using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFW2
{
    class Figura
    {
        protected double x;
        protected double y;
        protected double p;
        public double P
        {
            get { return p; }
            set { this.p = value; }
        }
        public Figura(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void Povrsina()
        {
            return;
        }
    }
}
