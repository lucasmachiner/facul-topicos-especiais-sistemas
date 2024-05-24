using ExemploORM.Models;
using Microsoft.EntityFrameworkCore;

namespace ExemploORM.Data
{
  public class UserDbContext : DbContext
  {
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }
    public DbSet<UserModel> User { get; set; }
  }
}