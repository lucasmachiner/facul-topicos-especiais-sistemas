using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace loja.Data
{
    public class DbContextFactory : IDesignTimeDbContextFactory<LojaDbCDbContext>
    {
        public LojaDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LojaDbContext>();

            //Build configuration
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 36)));

            return new LojaDbContext(optionsBuilder.Options);
        }
    }
}