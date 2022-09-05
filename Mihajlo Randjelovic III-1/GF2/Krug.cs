using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF2
{
    class Krug : Figura
    {
        public Krug(double x, double y) : base(x, y)
        {
        }
        public override void Povrsina()
        {
            //base.Povrsina();
            this.p = (x * x + y * y) * Math.PI;
        }
    }
}
