using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF2
{
    class Trougao : Figura
    {
        public Trougao(double x, double y) : base(x, y)
        {
        }
        public override void Povrsina()
        {
            //base.Povrsina();
            this.p = (x + y / 2);
        }
    }
}
