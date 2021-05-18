using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Trofi.Models
{
    public enum StatusNarudžbe
    {
        [Display(Name = "KreiranjeNarudžbe")]
        KreiranjeNarudžbe,
        [Display(Name = "Pokrenuta")]
        Pokrenuta,
        [Display(Name="Prihvaćena")]
        Prihvaćena,
        [Display(Name = "Pokupljena")]
        Pokupljena,
        [Display(Name = "Uručena")]
        Uručena,
        [Display(Name = "Odbijena")]
        Odbijena,
    }
    public enum NačinPlaćanja
    {
        [Display(Name = "Pouzeću")]
        Pouzeću,
        [Display(Name = "PayPal")]
        PayPal
    }
    public class Narudžba
    {
        [Key]
        private readonly int id;
        private double cijena;
        [EnumDataType(typeof(NačinPlaćanja))]
        private NačinPlaćanja načinPlaćanja;
        [EnumDataType(typeof(StatusNarudžbe))]
        private StatusNarudžbe statusNarudžbe;
        
        private Dictionary<Jelo,int> jela;

        private InfoNarudžbe info;

        public Narudžba(int id,Naručilac naručilac)
        {
            this.id = id;
            this.statusNarudžbe = StatusNarudžbe.Pokrenuta;
            this.jela = new Dictionary<Jelo, int>();
            this.info = new InfoNarudžbe(this.id, naručilac);
            cijena = 0;
        }

        public int Id { get => id;}
        public double Cijena { get => cijena;}
        public NačinPlaćanja NačinPlaćanja { get => načinPlaćanja; set => načinPlaćanja = value; }
        public StatusNarudžbe StatusNarudžbe { get => statusNarudžbe; set => statusNarudžbe = value; }
        public Dictionary<Jelo,int> Jela { get => jela; set => jela = value; }
        public InfoNarudžbe Info { get => info; set => info = value; }
        public void DodajJelo(Jelo jelo, int kolicina)
        {
            if (jela.ContainsKey(jelo))
            {
                if (kolicina > 0)
                {
                    jela[jelo] += kolicina;
                    cijena += kolicina * jelo.Cijena;
                }
                else
                {
                    if (jela[jelo] >= kolicina)
                    {
                        jela[jelo] -= kolicina;
                        cijena -= kolicina * jelo.Cijena;
                    }
                    else
                    {
                        //error
                    }
                }
            }
            else
            {
                //dodaj if za validaciju
                jela[jelo] = kolicina;
                cijena += jelo.Cijena * kolicina;
            }
        }

    }
}
