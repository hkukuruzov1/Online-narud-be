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
        [Key]
        private int id;
        [Required]
        [StringLength(maximumLength:20,MinimumLength =2,ErrorMessage ="Ime nije u opsegu od 2 do 20 karaktera!")]
        [RegularExpression(@"[A-Z]+[a-z]*")]
        private string ime;
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 2, ErrorMessage = "Prezime nije u opsegu od 2 do 20 karaktera!")]
        [RegularExpression(@"[A-Z]+[a-z]*")]
        private string prezime;
        [Required]
        [StringLength(maximumLength: 20, MinimumLength = 2, ErrorMessage = "Username nije u opsegu od 2 do 20 karaktera!")]
        [RegularExpression(@"[A-Z|a-z|0-9]+")]
        private string username;
        [Required]
        [StringLength(maximumLength:50,MinimumLength =5, ErrorMessage = "Password mora biti duži od 5, a kraći od 50 karaktera")]
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
