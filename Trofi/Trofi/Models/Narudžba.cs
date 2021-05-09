using System;
using System.Collections.Generic;


namespace Trofi.Models
{
    public enum StatusNarudžbe
    {
        KreiranjeNarudžbe,Pokrenuta,Prihvaćena,Pokupljena,Uručena,Odbijena,
    }
    public enum NačinPlaćanja
    {
        Pouzeću,PayPal
    }
    public class Narudžba
    {
        
        private readonly int id;
        private double cijena;
        private NačinPlaćanja načinPlaćanja;
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
