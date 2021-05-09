using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trofi.Models
{
    public enum VrstaVozila
    {
        Automobil,Bicikl,Motocikl
    }
    public class Dostavljač
    {
        private VrstaVozila vrstaVozila;
        private Narudžba aktivnaNarudžba;
        private Tuple<double, double> trenutneKoordinate;

        public Dostavljač(VrstaVozila vrstaVozila, Tuple<double, double> trenutneKoordinate)
        {
            this.vrstaVozila = vrstaVozila;
            this.trenutneKoordinate = trenutneKoordinate;
        }

        public VrstaVozila VrstaVozila { get => vrstaVozila;}
        public Narudžba AktivnaNarudžba { get => aktivnaNarudžba; set => aktivnaNarudžba = value; }
        public Tuple<double, double> TrenutneKoordinate { get => trenutneKoordinate; set => trenutneKoordinate = value; }
    }
}
