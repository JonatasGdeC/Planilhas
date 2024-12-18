using Microsoft.EntityFrameworkCore;

namespace Planilhas.Data;

public class ChurchDbContext : DbContext
{

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlite("Data Source=church_finance.db");
  }
}
