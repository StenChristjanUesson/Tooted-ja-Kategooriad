using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TootedJaKategooriad
{
    public class ProductsContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=products.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Seafood"},
                new Category { CategoryID = 2, CategoryName = "Pastries" },
                new Category { CategoryID = 3, CategoryName = "Sugar"},
                new Category { CategoryID = 4, CategoryName = "Teas"}
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductID = 1, CategoryID = 1, ProductName = "Fish Sticks" },
                new Product { ProductID = 2, CategoryID = 1, ProductName = "SeaBass" },
                new Product { ProductID = 3, CategoryID = 4, ProductName = "Matcha Tea" },
                new Product { ProductID = 4, CategoryID = 4, ProductName = "Green Tea" },
                new Product { ProductID = 5, CategoryID = 4, ProductName = "Black Tea" },
                new Product { ProductID = 6, CategoryID = 4, ProductName = "Oolong Tea" },
                new Product { ProductID = 7, CategoryID = 2, ProductName = "Garlic Bread" },
                new Product { ProductID = 8, CategoryID = 2, ProductName = "Melon Bread" },
                new Product { ProductID = 9, CategoryID = 1, ProductName = "Salmon" },
                new Product { ProductID = 10, CategoryID = 1, ProductName = "Shrimp" },
                new Product { ProductID = 11, CategoryID = 4, ProductName = "Earl Grey Tea" },
                new Product { ProductID = 12, CategoryID = 2, ProductName = "Jelly Doughnut" },
                new Product { ProductID = 13, CategoryID = 3, ProductName = "Honey" },
                new Product { ProductID = 14, CategoryID = 3, ProductName = "Maple Syrup" },
                new Product { ProductID = 15, CategoryID = 3, ProductName = "Brown Sugar" },
                new Product { ProductID = 16, CategoryID = 3, ProductName = "Grantulated Sugar" },
                new Product { ProductID = 17, CategoryID = 3, ProductName = "Powdered Sugar" },
                new Product { ProductID = 18, CategoryID = 3, ProductName = "Coconut Sugar" },
                new Product { ProductID = 19, CategoryID = 3, ProductName = "Cane Sugar" },
                new Product { ProductID = 20, CategoryID = 1, ProductName = "Lobster" },
                new Product { ProductID = 21, CategoryID = 1, ProductName = "Clams" },
                new Product { ProductID = 22, CategoryID = 1, ProductName = "Oysters" },
                new Product { ProductID = 23, CategoryID = 1, ProductName = "Cod" },
                new Product { ProductID = 24, CategoryID = 1, ProductName = "Mussels" },
                new Product { ProductID = 25, CategoryID = 1, ProductName = "Crab" },
                new Product { ProductID = 26, CategoryID = 1, ProductName = "Anchovies" },
                new Product { ProductID = 27, CategoryID = 1, ProductName = "Sardine" },
                new Product { ProductID = 28, CategoryID = 1, ProductName = "Eel" },
                new Product { ProductID = 29, CategoryID = 1, ProductName = "Octopus" },
                new Product { ProductID = 30, CategoryID = 2, ProductName = "Puff Pastry" },
                new Product { ProductID = 31, CategoryID = 2, ProductName = "Baklava" },
                new Product { ProductID = 32, CategoryID = 2, ProductName = "Croissant" },
                new Product { ProductID = 33, CategoryID = 2, ProductName = "Éclair" }
            );
        }
    }
}
