using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoArtigos.Models
{
    public class Estados
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_estado { get; set; }
        public String descricao { get; set; }
        public string UF { get; set; }

        public ICollection<Cidades> Cidades { get; set; }
    }
}
