using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit23
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik Pera;
            Profesor Vujic;
            string ime, prez, predmet;
            int godr, raz, odelj;

            Console.Write("Ime :");
            ime = Console.ReadLine();
            Console.Write("Prezime :");
            prez = Console.ReadLine();
            Console.Write("Godina rodjenja :");
            godr = int.Parse(Console.ReadLine());
            Console.Write("Razred :");
            raz = int.Parse(Console.ReadLine());
            Console.Write("Odeljenje :");
            odelj = int.Parse(Console.ReadLine());

            Pera = new Ucenik(ime, prez, godr, raz, odelj);

            Console.Write("Ime :");
            ime = Console.ReadLine();
            Console.Write("Prezime :");
            prez = Console.ReadLine();
            Console.Write("Godina rodjenja :");
            godr = int.Parse(Console.ReadLine());
            Console.Write("Predmet :");
            predmet = Console.ReadLine();

            Vujic = new Profesor(ime, prez, godr, predmet);

            Console.Clear();

            Pera.PredstaviSe();
            Console.WriteLine();
            Console.WriteLine();
            Vujic.PredstaviSe();

            Console.ReadKey();
        }
    }
}
