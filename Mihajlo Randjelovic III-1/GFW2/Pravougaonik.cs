using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFW2
{
    class Pravougaonik : Figura
    {
        public Pravougaonik(double x, double y) : base(x, y)
        {
        }
        public override void Povrsina()
        {
            //base.Povrsina();
            this.p = x * y;
        }
    }
}
