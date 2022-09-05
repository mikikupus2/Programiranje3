using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskaTela
{
    public class GTela : ITela
    {
        protected double r, h, p, v;
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
        public double P
        {
            get { return p; }
            set { p = value; }
        }
        public double V
        {
            get { return v; }
            set { v = value; }
        }

        public virtual void Povrsina()
        {}

        public virtual void Zapremina()
        {}
    }
    public class Valjak : GTela
    {
        public override void Povrsina()
        {
            p = 2 * (Math.Pow(r, 2) * Math.PI) + 2 * r * Math.PI * h;
        }
        public override void Zapremina()
        {
            v = Math.Pow(r, 2) * Math.PI * h;
        }
    }
    class Kupa : GTela
    {
        public override void Povrsina()
        {
            double s = Math.Sqrt(Math.Pow(H, 2) + Math.Pow(R, 2));
            P = Math.Pow(R, 2) * Math.PI + R * s * Math.PI;
        }
        public override void Zapremina()
        {
            V = (Math.Pow(R, 2) * Math.PI * H) / 3;
        }
   
    }

}
