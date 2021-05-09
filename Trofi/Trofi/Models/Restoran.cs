using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trofi.Models
{
    public class Restoran
    {
        private readonly string nazivRestorana;
        private List<Adresa> adrese;
        private List<Narudžba> aktivneNarudžbe;

        public Restoran(string nazivRestorana, List<Adresa> adrese)
        {
            this.nazivRestorana = nazivRestorana;
            this.adrese = adrese;

        }

        public string NazivRestorana { get => nazivRestorana; }
        public List<Adresa> Adrese { get => adrese; set => adrese = value; }
        public List<Narudžba> AktivneNarudžbe { get => aktivneNarudžbe; set => aktivneNarudžbe = value; }
        public void dodajNarudžbu(Narudžba narudžba)
        {
            aktivneNarudžbe.Add(narudžba);
        }
    }
}
