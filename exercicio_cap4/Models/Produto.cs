using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace exercicio_cap4.Models
{
    public class Produto
    {
        public long? ProdutoId { get; set; }
        public string Nome { get; set; }
        public long? CategoricoId { get; set; }
        public long? FabricanteId { get; set; }
        public Categorico Categorico { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}