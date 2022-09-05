using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometrijskaTela
{
    interface ITela
    {
        double R { get; set; }
        double H { get; set; }
        double P { get; set; }
        double V { get; set; }
        void Povrsina();
        void Zapremina();
    }
}
