using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoWebShop.Models;
using Microsoft.AspNetCore.Authorization;
using DemoWebShop.Data;
using System.Collections.Generic;

namespace DemoWebShop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _dbContex;

    // dependecy incjection

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext DbContex)
    {
        _logger = logger;
        _dbContex = DbContex;

    }
    //[Authorize]
    public IActionResult Index(string? searchQuery, int? orderBy, int? filterByCat)
    {
        // 1. ako searchQuery == null, učitaj sve
        // 2. ako searchQuery !=null
        List<Product> products = _dbContex.Products.ToList();
        List<Product> productsToShow = new List<Product>() ;


        // search products
        if (!String.IsNullOrWhiteSpace(searchQuery))
        {
            products = products.Where(p => p.Title.Contains(searchQuery.ToLower())).ToList();
        }

        // filter
        List < ProductCategory >  pcat = _dbContex.ProductCategories.ToList();
        if (filterByCat != null)
        {
            List<ProductCategory> filteredproducts = pcat.FindAll(c => c.CategoryId == filterByCat);
            foreach (var pc in filteredproducts)
            {
                Product product = products.Find(p => p.ProductId == pc.ProductId);
                productsToShow.Add(product);
            }
        }

        // sortiranje
        // Title asc/desc, price asc/desc
        switch (orderBy)
        {
            case 1: products = products.OrderBy(p => p.Title).ToList(); break;
            case 2: products = products.OrderByDescending(p => p.Title).ToList(); break;
            case 3: products = products.OrderBy(p => p.Price).ToList(); break;
            case 4: products = products.OrderByDescending(p => p.Price).ToList(); break;
            default: break;

        }

        return View(products);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

