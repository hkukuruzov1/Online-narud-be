using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trofi.Models
{
    public enum VrstaJela
    {
        [Display(Name = "Piće")]
        Piće,
        [Display(Name = "Slatko")]
        Slatko,
        [Display(Name = "Slano")]
        Slano
    }
    public class Jelo
    {
        [Key]
        private int id;
        [Required]
        
        private string naziv;
        
        [Required]
        [Range(0.0,Double.MaxValue)]
        private double cijena;
        [Required]
        
        [EnumDataType(typeof(VrstaJela))]
        private VrstaJela vrstaJela;
        [ForeignKey("idRestorana")]
        [Required]
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
