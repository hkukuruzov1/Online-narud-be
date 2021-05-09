using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trofi.Models
{
    public enum VrstaJela
    {
        Piće,Slatko,Slano
    }
    public class Jelo
    {
        private int id;
        private string naziv;
        private double cijena;
        private VrstaJela vrstaJela;
        private int idRestorana;
        public Jelo(int id, string naziv, double cijena, VrstaJela vrstaJela, int idRestorana)
        {
            this.id = id;
            this.naziv = naziv;
            this.cijena = cijena;
            this.vrstaJela = vrstaJela;
            this.idRestorana = idRestorana;
        }

        public int Id { get => id;}
        public string Naziv { get => naziv; set => naziv = value; }
        public double Cijena { get => cijena; set => cijena = value; }
        internal VrstaJela VrstaJela { get => vrstaJela; set => vrstaJela = value; }
    }
}
