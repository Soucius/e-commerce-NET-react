using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options): DbContext(options) {
    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new List<Product> {
                new Product { Id = 1, Name = "iPhone 15", Description = "Telefon Aciklamasi", ImageUrl = "1.jpg", Price = 70000, IsActive = true, Stock = 100 },
                new Product { Id = 2, Name = "iPhone 16", Description = "Telefon Aciklamasi", ImageUrl = "2.jpg", Price = 80000, IsActive = true, Stock = 100 },
                new Product { Id = 3, Name = "iPhone 16 Pro", Description = "Telefon Aciklamasi", ImageUrl = "3.jpg", Price = 90000, IsActive = false, Stock = 100 },
                new Product { Id = 4, Name = "iPhone 16 Pro Max", Description = "Telefon Aciklamasi", ImageUrl = "4.jpg", Price = 100000, IsActive = true, Stock = 100 },
            }
        );
    }
}