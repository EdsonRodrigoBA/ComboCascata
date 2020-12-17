using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoArtigos.Models
{
    public class ClienteViewModel
    {
        public String CPF { get; set; }
        public String Nome { get; set; }
        public int id_cidade { get; set; }

        public int id_estado { get; set; }
    }
}
