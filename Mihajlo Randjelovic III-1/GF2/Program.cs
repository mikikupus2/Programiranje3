using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GF2
{
    class Program
    {
        static void Main(string[] args)
        {
            Figura F = null;
            Pravougaonik P;
            Krug K;
            Trougao T;

            double x, y;
            char t;
            bool kraj = false;
            while (!kraj) 
            {
                Console.Write("x=");
                x = double.Parse(Console.ReadLine());
                if (x == 0)
                {
                    kraj = true;
                    continue;
                }
                Console.Write("y=");
                y = double.Parse(Console.ReadLine());
                Console.Write("Figura :");
                t = Convert.ToChar(Console.ReadLine());
                switch(t)
                {
                    case 'K':
                        K = new Krug(x, y);
                        F = (Figura)K;
                        break;
                    case 'T':
                        T = new Trougao(x, y);
                        F = (Figura)T;
                        break;
                    case 'P':
                        P = new Pravougaonik(x, y);
                        F = (Figura)P;
                        break;
                }
                F.Povrsina();
                Console.WriteLine("Povrsina figure je :" + F.P);
            }
        }
    }
}
