using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Zadat je interfejs devize. koji ima svojstva kupovni kurs i prodajni kurs realni brojevi i metode 
void Kupovina(double iznos);, 
void prodaja(double iznos);,
void Stanje(),
Klasa Menjacnica implementira interfejs i ima podatke clanove realne brojeve za kolicinu evra i dinara u menjacnici.Njihove pocetne vrednosti postavljaju se pomocu
konstruktora pomocu koga se upisuju i kupovni i prodajni kurs evra.
Napraviti Windows Aplikaciju koja simulira rad menjacnice koristeci datu klasu.
kupovni kurs 118
prodajni kurs 120*/
namespace ProjekatMenjacnica
{
    class Menjacnica : IDevize
    {
        private double prodajnikurs,kupovnikurs,kolicinaevra,kolicinadinara;
        public double ProdajniKurs
        {
            get { return prodajnikurs; }
            set { prodajnikurs = value; }
        }
        public double KupovniKurs
        {
            get { return kupovnikurs; }
            set { kupovnikurs = value; }
        }
        public void Prodaja(double iznos)
        {
            kolicinaevra = kolicinaevra - iznos;
            kolicinadinara = kolicinadinara + iznos * prodajnikurs;

        }
        public void Kupovina(double iznos)
        {
            kolicinaevra = kolicinaevra + iznos;
            kolicinadinara = kolicinadinara - iznos * kupovnikurs;
        }
        public string Stanje()
        {
            return "Kolicina Eura :" + kolicinaevra.ToString() + Environment.NewLine +
                "Kolicina dinara:" + kolicinadinara.ToString();
        }
        public Menjacnica(double kupovni_kurs, double prodajni_kurs, double kolicina_evra, double kolicina_dinara)
        {
            kupovnikurs = kupovni_kurs;
            prodajnikurs = prodajni_kurs;
            kolicinaevra = kolicina_evra;
            kolicinadinara = kolicina_dinara;
        }
        public double Kolicinaevra
        {
            get { return kolicinaevra; }
        }
        public double Kolicinadinara
        {
            get { return kolicinadinara; }
        }
    }
}