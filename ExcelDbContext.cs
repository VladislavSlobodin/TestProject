using System.Data.Entity;

namespace TestProject;

public class ExcelDbContext : DbContext
{
    public DbSet<BalanceUnit> BalanceUnits { get; set; } = null!;
}
