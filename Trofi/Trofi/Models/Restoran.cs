using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trofi.Models
{
    public class Restoran: Korisnik
    {
        [Required]
        [StringLength(maximumLength:50,MinimumLength =1)]
        private readonly string nazivRestorana;
        private List<Adresa> adrese;
        private List<Narudžba> aktivneNarudžbe;
        private Meni meni;

        public Restoran(int id, string ime, string prezime, string email, string username, string password,string nazivRestorana,List<Adresa> adrese) : base(id, ime, prezime, email, username, password)
        {
            this.nazivRestorana = nazivRestorana;
            this.adrese = adrese;
        }

        public string NazivRestorana { get => nazivRestorana; }
        public List<Adresa> Adrese { get => adrese; set => adrese = value; }
        public List<Narudžba> AktivneNarudžbe { get => aktivneNarudžbe; set => aktivneNarudžbe = value; }
        public Meni Meni { get => meni; set => meni = value; }

        public void dodajNarudžbu(Narudžba narudžba)
        {
            aktivneNarudžbe.Add(narudžba);
        }
    }
}
