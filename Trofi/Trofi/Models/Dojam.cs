using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Trofi.Models
{
    public class Dojam
    {
        [Key]
        private int idDojma;
        [ForeignKey("IdNarudžbe")]
        private int idNarudžbe;
        [Range(1,5)]
        private double ocjenaResotana;
        [Range(1,5)]
        private double ocjenaDostavljača;

        public int IdDojma { get => idDojma; set => idDojma = value; }
        public int IdNarudžbe { get => idNarudžbe; set => idNarudžbe = value; }
        public double OcjenaResotana { get => ocjenaResotana; set => ocjenaResotana = value; }
        public double OcjenaDostavljača { get => ocjenaDostavljača; set => ocjenaDostavljača = value; }
    }
}
