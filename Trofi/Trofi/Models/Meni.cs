using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trofi.Models
{
    public class Meni
    {
        private int idRestorana;
        private List<Jelo> jela;

        public Meni(int idRestorana, List<Jelo> jela)
        {
            this.idRestorana = idRestorana;
            this.jela = jela;
        }

        public int IdRestorana { get => idRestorana; set => idRestorana = value; }
        public List<Jelo> Jela { get => jela; set => jela = value; }
        public int BrojJela { get => jela.Count; }

    }
}
