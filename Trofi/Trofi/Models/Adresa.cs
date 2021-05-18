using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trofi.Models
{
    public class Adresa
    {
        [Required]
        [RegularExpression("[A-Z][A-Z|a-z| ]*")]
        private string naziv;
        [Required]
        [Range(0,int.MaxValue)]
        private int broj;
        [RegularExpression(@"[A-Z][a-z]*")]
        private string grad;
        [Range(0,int.MaxValue)]
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
