using Microsoft.EntityFrameworkCore;
using Planilhas.Models;

namespace Planilhas.Data;

public class ChurchDbContext : DbContext
{
  public DbSet<RegisterDeposit> RegisterDeposit { get; set; }
  public DbSet<RegisterInputs> RegisterInputs { get; set; }
  public DbSet<RegisterOutputs> RegisterOutputs { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlite("Data Source=church_finance.db");
  }
}
