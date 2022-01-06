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
        #region User

        modelBuilder.Entity<User>()
        .HasIndex(u => u.Username)
        .IsUnique(true);

        #endregion
        
        //TODO alterar relacionamento
        //TODO Ler sobre navigation
        //TODO Rodar migration

        #region ExpenseData

        modelBuilder.Entity<ExpenseData>()
       .HasOne(u => u.User)
       .WithMany(e => e.Expenses);

        modelBuilder.Entity<ExpenseData>()
        .Property(dc => dc.DtCreated)
       .ValueGeneratedOnAdd();

        modelBuilder.Entity<ExpenseData>()
       .Property(dc => dc.DtUpdate)
       .ValueGeneratedOnAddOrUpdate();

        #endregion

        #region Category

        modelBuilder.Entity<Category>()
       .HasOne(u => u.User)
       .WithMany(c => c.Categories);

        modelBuilder.Entity<Category>()
        .Property(dc => dc.DtCreated)
        .ValueGeneratedOnAdd();

        modelBuilder.Entity<Category>()
       .Property(dc => dc.DtUpdate)
    .ValueGeneratedOnAddOrUpdate();

        #endregion

        base.OnModelCreating(modelBuilder);
    }
}
