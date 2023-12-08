using Microsoft.EntityFrameworkCore;
namespace Space.Data;

public sealed class SpaceDbContext : DbContext
{
    public DbSet<Roket> Rokets {get; set;}
    public DbSet<Employee> Employees {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(optionsBuilder.IsConfigured)
            return;
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User ID=postgres;Password=typedef;Database=Space_EXplorers_LAB");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
         modelBuilder.ApplyConfiguration(new RoketConfiguration());
    }
}   