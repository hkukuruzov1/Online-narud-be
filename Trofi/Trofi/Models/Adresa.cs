using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trofi.Models
{
    public class Adresa
    {
        private string naziv;
        private int broj;
        private string grad;
        private int poštanskiBroj;

        public Adresa(string naziv, int broj, string grad, int poštanskiBroj)
        {
            this.naziv = naziv;
            this.broj = broj;
            this.grad = grad;
            this.poštanskiBroj = poštanskiBroj;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public int Broj { get => broj; set => broj = value; }
        public string Grad { get => grad; set => grad = value; }
        public int PoštanskiBroj { get => poštanskiBroj; set => poštanskiBroj = value; }
    }
}
