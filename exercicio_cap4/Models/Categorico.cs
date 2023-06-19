using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exercicio_cap4.Models
{
    public class Categorico
    {

        public long CategoricoId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }

    }
}