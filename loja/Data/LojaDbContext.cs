using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loja.Data
{
    public class LojaDbContext : DbContext
    {
        public LojaDbContext(DbContextOptions<LojaDbContext> options) : base(options) { }
        publicDbSet<ProducesResponseTypeMetadata> Produtos { get; set; }
    }
}