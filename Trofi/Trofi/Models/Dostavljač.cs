using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trofi.Models
{
    public enum VrstaVozila
    {
        [Display(Name = "Automobil")]
        Automobil,
        [Display(Name = "Bicikl")]
        Bicikl,
        [Display(Name = "Motocikl")]
        Motocikl
    }
    public class Dostavljač: Korisnik
    {
        [EnumDataType(typeof(VrstaVozila))]
        private VrstaVozila vrstaVozila;
        private Narudžba aktivnaNarudžba;
        private Tuple<double, double> trenutneKoordinate;

        public Dostavljač(int id, string ime, string prezime, string email, string username, string password,VrstaVozila vrstaVozila) : base(id, ime, prezime, email, username, password)
        {
            this.vrstaVozila = vrstaVozila;
        }

        public VrstaVozila VrstaVozila { get => vrstaVozila;}
        public Narudžba AktivnaNarudžba { get => aktivnaNarudžba; set => aktivnaNarudžba = value; }
        public Tuple<double, double> TrenutneKoordinate { get => trenutneKoordinate; set => trenutneKoordinate = value; }
    }
}
