using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lojaNova.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }
        public string? Fornecedor { get; set; }
    }
}