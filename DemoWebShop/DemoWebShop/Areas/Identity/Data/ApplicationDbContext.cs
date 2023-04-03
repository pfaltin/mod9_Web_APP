using DemoWebShop.Areas.Identity.Data;using DemoWebShop.Models;using Microsoft.AspNetCore.Identity;using Microsoft.AspNetCore.Identity.EntityFrameworkCore;using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace MVC1.Data;public class ApplicationDbContext : IdentityDbContext<ApplicationUser>{    public DbSet<Category> Categories { get; set; }    public DbSet<Order> Orders { get; set; }    public DbSet<OrderItem> OrderItems { get; set; }    public DbSet<Product> Products { get; set; }    public DbSet<ProductCategory> ProductCategories { get; set; }    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)        : base(options)    {    }    protected override void OnModelCreating(ModelBuilder builder)    {        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        //  Za ponedjeljak potrebno je kreirati seeding podataka za
        //  5 proizvoljnih kategorija i
        builder.Entity<Category>().HasData(
            new Category { CatrgoryId = 1, Description = "Cat desc 1", Image = "/1catimg.png", Title = "Kreme" },
            new Category { CatrgoryId = 2, Description = "Cat desc 2", Image = "/2catimg.png", Title = "Losioni" },
            new Category { CatrgoryId = 3, Description = "Cat desc 3", Image = "/3catimg.png", Title = "Dezodoransi" },
            new Category { CatrgoryId = 4, Description = "Cat desc 4", Image = "/4catimg.png", Title = "Eter Ulja" },
            new Category { CatrgoryId = 5, Description = "Cat desc 5", Image = "/5catimg.png", Title = "Razno" });

        //  5 proizvoljnih proizvoda
        builder.Entity<Product>().HasData(
            new Product { ProductId = 1, Title = "AARt", Description = "A", Image = "/a.png", InStock = 1.00M, Price = 1.01M, Sku = "SA" },
            new Product { ProductId = 2, Title = "BArt", Description = "B", Image = "/b.png", InStock = 2.00M, Price = 2.01M, Sku = "SB" },
            new Product { ProductId = 3, Title = "CArt", Description = "C", Image = "/c.png", InStock = 3.00M, Price = 3.01M, Sku = "SC" },
            new Product { ProductId = 4, Title = "DArt", Description = "D", Image = "/d.png", InStock = 4.00M, Price = 4.01M, Sku = "SD" },
            new Product { ProductId = 5, Title = "EARt", Description = "E", Image = "/e.png", InStock = 5.00M, Price = 5.01M, Sku = "SE" });    }}