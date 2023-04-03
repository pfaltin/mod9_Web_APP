using Microsoft.AspNetCore.Identity;using Microsoft.EntityFrameworkCore;using DemoWebShop.Areas.Identity.Data;using MVC1.Data;namespace DemoWebShop;public class Program{    public static void Main(string[] args)    {        var builder = WebApplication.CreateBuilder(args);

        // dohvat connection string
        var connectionString = builder.Configuration.GetConnectionString("DevStatM") ?? throw new InvalidOperationException("Connection string 'DevStatM' not found.");
        // var connectionString = builder.Configuration.GetConnectionString("DevStatW") ?? throw new InvalidOperationException("Connection string 'DevStatW' not found.");        builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));        builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<ApplicationDbContext>();        // Add services to the container.        builder.Services.AddControllersWithViews();        // kreiranje servisa za koristenje RAZOR page opcija        builder.Services.AddRazorPages();        var app = builder.Build();        // Configure the HTTP request pipeline.        if (!app.Environment.IsDevelopment())        {            app.UseExceptionHandler("/Home/Error");            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.            app.UseHsts();        }        app.UseHttpsRedirection();        app.UseStaticFiles();        app.UseRouting();        app.UseAuthentication();        app.UseAuthorization();        app.MapControllerRoute(            name: "default",            pattern: "{controller=Home}/{action=Index}/{id?}");        app.MapRazorPages();        app.Run();    }}