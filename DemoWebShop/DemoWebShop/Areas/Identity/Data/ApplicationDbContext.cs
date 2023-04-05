using DemoWebShop.Areas.Identity.Data;using DemoWebShop.Models;using Microsoft.AspNetCore.Identity;using Microsoft.AspNetCore.Identity.EntityFrameworkCore;using Microsoft.EntityFrameworkCore;using System.Reflection.Emit;namespace DemoWebShop.Data;public class ApplicationDbContext : IdentityDbContext<ApplicationUser>{    public DbSet<Category> Categories { get; set; }    public DbSet<Order> Orders { get; set; }    public DbSet<OrderItem> OrderItems { get; set; }    public DbSet<Product> Products { get; set; }    public DbSet<ProductCategory> ProductCategories { get; set; }    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)        : base(options)    {    }    protected override void OnModelCreating(ModelBuilder builder)    {        base.OnModelCreating(builder);        // Customize the ASP.NET Identity model and override the defaults if needed.        // For example, you can rename the ASP.NET Identity table names and more.        // Add your customizations after calling base.OnModelCreating(builder);        //  Za ponedjeljak potrebno je kreirati seeding podataka za        //  5 proizvoljnih kategorija i        builder.Entity<Category>().HasData(            new Category { CategoryId = 1, Description = "Cat desc 1", Image = "/1catimg.png", Title = "1.Cat" },            new Category { CategoryId = 2, Description = "Cat desc 2", Image = "/2catimg.png", Title = "2.Cat" },            new Category { CategoryId = 3, Description = "Cat desc 3", Image = "/3catimg.png", Title = "3.Cat" },            new Category { CategoryId = 4, Description = "Cat desc 4", Image = "/4catimg.png", Title = "4.Cat" },            new Category { CategoryId = 5, Description = "Cat desc 5", Image = "/5catimg.png", Title = "5.Cat" });        //  5 proizvoljnih proizvoda        builder.Entity<Product>().HasData(            new Product { ProductId = 1, Title = "AARt", Description = "A", Image = "/a.png", InStock = 1.00M, Price = 1.01M, Sku = "SA" },            new Product { ProductId = 2, Title = "BArt", Description = "B", Image = "/b.png", InStock = 2.00M, Price = 2.01M, Sku = "SB" },            new Product { ProductId = 3, Title = "CArt", Description = "C", Image = "/c.png", InStock = 3.00M, Price = 3.01M, Sku = "SC" },            new Product { ProductId = 4, Title = "DArt", Description = "D", Image = "/d.png", InStock = 4.00M, Price = 4.01M, Sku = "SD" },            new Product { ProductId = 5, Title = "EARt", Description = "E", Image = "/e.png", InStock = 5.00M, Price = 5.01M, Sku = "SE" });

        // postavke za seedanje uloga i Admina

        // Tablica AspNetRoles - identity klasa IdentityRole
        string AdminRoleId = "5109cf15 - d38d - 4fe9 - b385 - 2972b2d2bb20";        string AdminRoleTitle = "Administrators";        string UserRoleId = "41112308 - 4603 - 420b - be22 - 3af8a2166be1";        string UserRoleTitle = "Customers";        builder.Entity<IdentityRole>().HasData(            new IdentityRole { Id = AdminRoleId, Name = AdminRoleTitle, NormalizedName = AdminRoleTitle.ToUpper()},            new IdentityRole { Id = UserRoleId, Name = UserRoleTitle, NormalizedName = UserRoleTitle.ToUpper()});

        // Tablic AspNetUsers - izvorna klasa Aplication User : izvorna Identityuser
        string adminUserId = "e4e48ebc - dde2 - 44ef - aa10 - f77c91acc588";
        string adminUser = "admin@tvrtka.com";
        string adminEmail = "admin@tvrtka.com";
        string adminFirstName = "Tvrtko";
        string adminLastName = "Tvrdic";
        string adminPwd = "Lozinka09";
        string adminAddr = "Donji Glib 56";

        // za hash
        var hasher = new PasswordHasher<ApplicationUser>();

        builder.Entity<ApplicationUser>().HasData(
            new ApplicationUser { Id = adminUserId, UserName = adminUser, FirstName = adminFirstName, LastName = adminLastName, Email = adminEmail, Address = adminAddr, PasswordHash = hasher.HashPassword(null, adminPwd), NormalizedUserName= adminUser.ToUpper(), NormalizedEmail=adminEmail.ToUpper() });
        // Tablica veza users & roles
        builder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>()
            {
                UserId = adminUserId,
                RoleId = AdminRoleId
            }
            ); 

        



    }}