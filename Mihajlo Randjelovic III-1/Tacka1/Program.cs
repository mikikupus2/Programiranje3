using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tacka1
{
    class Tacka
    {
        private double x;
        private double y;
        private double d;
        public double D
        {
            get 
            {return this.d; }
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
            this.d = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tacka a;
            double ax, ay, ad;
            System.Console.Write("a.x=");
            ax = double.Parse(System.Console.ReadLine());
            System.Console.Write("a.y=");
            ay = double.Parse(System.Console.ReadLine());

            a = new Tacka(); //a = new Tacka(ax,ay);
            a.X = ax;
            a.Y = ay;
            a.Rastojanje();
            Console.WriteLine("d= {0,6:f2}", a.D);
            Console.ReadLine();
        }
    }
}
/*Definisati klasu koja predstavlja tacku u ravni koa ima podatke clanove dva realna broja-koordinate x i y i realan broj koji
 predstavlja udaljenost od koordinatnog pocetka. Klasa ima metodu(funkciju) ya izracunavanje rastojanja od koordinatnog pocetka.
U okviru glavnog programa uneti sa tastature koordinate x i y, kreirati objekat klase tacka i prikazati na ekranu
rastojanje te tacke od koordinatnog pocetka.*/