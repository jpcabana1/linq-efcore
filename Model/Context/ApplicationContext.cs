using Microsoft.EntityFrameworkCore;
using Model;

namespace Expenses;


public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ExpenseData> Expenses { get; set; }
    public ApplicationContext(DbContextOptions<ApplicationContext> options)
    : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
        .HasIndex(u => u.Username)
        .IsUnique(true);

        modelBuilder.Entity<ExpenseData>()
       .HasOne(u => u.User)
       .WithMany(e => e.Expenses);

        modelBuilder.Entity<Category>()
       .HasOne(u => u.User)
       .WithMany(c => c.Categories);

        base.OnModelCreating(modelBuilder);
    }
}
