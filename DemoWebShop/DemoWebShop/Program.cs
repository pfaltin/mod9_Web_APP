using Microsoft.AspNetCore.Identity;using Microsoft.EntityFrameworkCore;using DemoWebShop.Areas.Identity.Data;using DemoWebShop.Data;using System.Globalization;using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace DemoWebShop;public class Program{    public static void Main(string[] args)    {        var builder = WebApplication.CreateBuilder(args);

        // dohvat connection string
        // var connectionString = builder.Configuration.GetConnectionString("DevStatM") ?? throw new InvalidOperationException("Connection string 'DevStatM' not found.");
        // var connectionString = builder.Configuration.GetConnectionString("DevStatW") ?? throw new InvalidOperationException("Connection string 'DevStatW' not found.");

        var connectionString = "";

        

        if (!builder.Environment.IsEnvironment("Production"))
        {
            // ako okruženje nije produkcijsko
            connectionString = builder.Configuration.GetConnectionString("DevStatM");

        }
        else
        {
            connectionString = Environment.GetEnvironmentVariable("WEB_MODUL9_CONN_STRING");
        }



builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));        builder.Services.            AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)            .AddRoles<IdentityRole>()            .AddEntityFrameworkStores<ApplicationDbContext>();        builder.Services.Configure<IdentityOptions>(options =>        {            // Default Password settings.            options.Password.RequireDigit = true;            options.Password.RequireLowercase = true;            options.Password.RequireNonAlphanumeric = false;            options.Password.RequireUppercase = true;            options.Password.RequiredLength = 6;            options.Password.RequiredUniqueChars = 1;        });        // Add services to the container.        builder.Services.AddControllersWithViews();        // kreiranje servisa za koristenje RAZOR page opcija        builder.Services.AddRazorPages();

        // kreiranj srervisa za sesiju
        builder.Services.AddDistributedMemoryCache();
        builder.Services.AddSession();



var app = builder.Build();        // Configure the HTTP request pipeline.        if (!app.Environment.IsDevelopment())        {            app.UseExceptionHandler("/Home/Error");            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.            app.UseHsts();        }        app.UseHttpsRedirection();        app.UseStaticFiles();        // postavke za rukovanje decimalnim vrijednostima        var ci = new CultureInfo("de-De");        ci.NumberFormat.NumberDecimalSeparator = ".";        ci.NumberFormat.CurrencyDecimalSeparator = ".";        app.UseRequestLocalization(            new RequestLocalizationOptions            {                DefaultRequestCulture = new Microsoft.AspNetCore.Localization.RequestCulture(ci),                SupportedCultures = new List<CultureInfo> { ci },                SupportedUICultures = new List<CultureInfo> { ci }            }                        );        app.UseRouting();        app.UseAuthentication();        app.UseAuthorization();        app.UseSession();        app.MapAreaControllerRoute(            name: "Admin",            areaName: "Admin",            pattern: "admin/{controller}/{action}/{id?}"            );        app.MapControllerRoute(            name: "default",            pattern: "{controller=Home}/{action=Index}/{id?}");        app.MapRazorPages();        app.Run();    }}
