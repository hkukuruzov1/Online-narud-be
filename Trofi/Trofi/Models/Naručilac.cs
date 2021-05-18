using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trofi.Models
{
    public class Naručilac : Korisnik
    {
        private List<Adresa> adrese=new List<Adresa>();
        private Narudžba narudžba;
        public Naručilac(int id, string ime, string prezime, string email, string username, string password) : base(id, ime, prezime, email, username, password)
        {
            
        }

        public Narudžba Narudžba { get => narudžba; set => narudžba = value; }
    }
}
