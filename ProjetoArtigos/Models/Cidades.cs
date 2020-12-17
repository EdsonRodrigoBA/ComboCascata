using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoArtigos.Models
{
    public class Cidades
    {
        public int Id_Cidade { get; set; }
        public int Id_estado { get; set; }
        public string descricao { get; set; }
        public String UF { get; set; }
        public int Codigo_Ibge { get; set; }

        public Estados Estados { get; set; }
        public int Capital { get; set; }

    

    }
}
