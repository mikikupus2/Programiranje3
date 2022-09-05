using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
napisati klasu kvadrat koja ima podatke clanove stranice kvadrata i povrsina
stranica kvadrata unosi se pomocu konstruktura
za povrsinu napisati funkciju a*a koja ce biti void
preklopiti operatore ==(dva kvadrata su jednaka ako su im jednake stranice)
i operator + koji kao rezutat vraca novi kvadrat cija je povrsina jednaka zbiru povrsina dva kvadrata koji su operandi i preracunavamo duzinu stranice
korenom povrsine.
napisati win aplikacuju koja omogucava unos stranica za prvi i drugi kvadrat i ako su kvadrati razliciti sabrati ih i prikazati stranicu i povrsinu
rezultantnog kvadrata, ako su isti rezultantni kvadrat jednak je prvom kvadratu.*/
namespace OperatoriKvadrat
{
    class Kvadrat
    {
        private double stranica, povrsina;
        public Kvadrat(double stranica)
        {
            this.stranica = stranica;
            //this.IzracunajPovrsinu();
        }
        private void IzracunajPovrsinu()
        {
            povrsina = stranica * stranica;
        }
        public double Stranica
        {
            get { return stranica; }
        }
        public double Povrsina
        {
            get { return povrsina; }
            set { povrsina = value; }
        }
        public static Kvadrat operator +(Kvadrat k1, Kvadrat k2)
        {
            k1.IzracunajPovrsinu();
            k2.IzracunajPovrsinu();
            Kvadrat k3 = new Kvadrat(Math.Sqrt(k1.povrsina + k2.povrsina));
            return k3;
        }
        public static bool operator ==(Kvadrat k1,Kvadrat k2)
        {
            if (k1.stranica == k2.stranica)
                return true;
            else
                return false;
        }
        public static bool operator !=(Kvadrat k1, Kvadrat k2)
        {
            return !(k1.stranica == k2.stranica);
        }
        public override bool Equals(object obj)
        {
            if (!(obj is Kvadrat))
                return false;
            else
                return this == (Kvadrat)obj;
        }
    }
}
