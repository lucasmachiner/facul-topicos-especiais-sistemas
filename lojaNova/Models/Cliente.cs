using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lojaNova.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Email { get; set; }
    }
}