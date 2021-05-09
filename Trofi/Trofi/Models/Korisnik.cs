using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Trofi.Models
{
    public  abstract class Korisnik
    {
        [Required]
        private int id;
        [Required]
        private string ime, prezime, username;
        [Required]
        private string password;
        [EmailAddress]
        private string email;
        protected Korisnik(int id, string ime, string prezime, string email, string username, string password)
        {
            this.id = id;
            this.ime = ime;
            this.prezime = prezime;
            this.email = email;
            this.username = username;
            this.password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
