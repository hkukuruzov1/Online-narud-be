using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trofi.Models
{
    public class InfoNarudžbe
    {
        [Key]
        private int idNarudžbe;
        private Tuple<double, double> polazneKoordinate;
        private Tuple<double, double> koordinateRestorana;
        private Tuple<double, double> koordinateNaručioca;
        [DataType(DataType.Date)]
        private DateTime vrijemePočetka;
        [DataType(DataType.Date)]
        private DateTime vrijemeSvršetka;
        [Required]
        private Naručilac naručilac;
        private Dostavljač dostavljač;
        private Restoran restoran;
        private double dužinaPuta;
        private Dojam dojamDostave;
        public InfoNarudžbe(int idNarudžbe, Naručilac naručilac)
        {
            this.idNarudžbe = idNarudžbe;
            this.naručilac = naručilac;
        }

        public int IdNarudžbe { get => idNarudžbe; set => idNarudžbe = value; }
        public Tuple<double, double> PolazneKoordinate { get => polazneKoordinate; set => polazneKoordinate = value; }
        public Tuple<double, double> KoordinateRestorana { get => koordinateRestorana; set => koordinateRestorana = value; }
        public DateTime VrijemePočetka { get => vrijemePočetka; set => vrijemePočetka = value; }
        public DateTime VrijemeSvršetka { get => vrijemeSvršetka; set => vrijemeSvršetka = value; }
        public Naručilac Naručilac { get => naručilac;}
        public Dostavljač Dostavljač { get => dostavljač; set => dostavljač = value; }
        public Restoran Restoran { get => restoran; set => restoran = value; }
        public Tuple<double, double> KoordinateNaručioca { get => koordinateNaručioca; set => koordinateNaručioca = value; }
        public double DužinaPuta { get => dužinaPuta; set => dužinaPuta = value; }
        public Dojam DojamDostave { get => dojamDostave; set => dojamDostave = value; }
    }
}
