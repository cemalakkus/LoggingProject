using Microsoft.EntityFrameworkCore;
using CQRSProject.Domain.Common;
using CQRSProject.Domain.Entities;
using System.Reflection;

namespace CQRSProject.Persistence.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>().HasData(
            new Product() { Id = Guid.NewGuid(), Name = "Pen", Price = 10, Quantity = 100, CreatedBy = "0", Created = DateTime.Now },
            new Product() { Id = Guid.NewGuid(), Name = "Paper A4", Price = 4, Quantity = 200, CreatedBy = "0", Created = DateTime.Now },
            new Product() { Id = Guid.NewGuid(), Name = "Book", Price = 30, Quantity = 500, CreatedBy = "0", Created = DateTime.Now }
            );
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<BaseEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.Created = DateTime.Now;
                    entry.Entity.CreatedBy = string.Empty;
                    break;
                case EntityState.Modified:
                    entry.Entity.LastModified = DateTime.Now;
                    entry.Entity.LastModifiedBy = string.Empty;
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}
