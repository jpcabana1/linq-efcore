using Microsoft.EntityFrameworkCore;

public class ApplicationContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ExpenseData> Expenses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<User>()
        .HasIndex(u => u.Username)
        .HasFilter("[Username] IS NOT NULL")
        .IsUnique();

        modelBuilder.Entity<User>().HasData(
            new User { Username = "user1", Password = "pass", Active = true },
            new User { Username = "user2", Password = "pass", Active = true },
            new User { Username = "user3", Password = "pass", Active = true }
        );

        modelBuilder.Entity<ExpenseData>()
        .HasOne(u => u.User)
        .WithMany(e => e.Expenses)
        .HasForeignKey(u => u.User.Id)
        .HasForeignKey(c => c.Category.Id);

        modelBuilder.Entity<Category>()
       .HasOne(u => u.User)
       .WithMany(c => c.Categories)
       .HasForeignKey(u => u.User.Id);

    }
}
