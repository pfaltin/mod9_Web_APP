using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DemoWebShop.Models;
using Microsoft.AspNetCore.Authorization;
using DemoWebShop.Data;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

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
    public IActionResult Index(string? searchQuery, int? orderBy, string? filterByCat)
    {
        // 1. ako searchQuery == null, učitaj sve
        // 2. ako searchQuery !=null
        List<Product> products = _dbContex.Products.ToList();
        List<Product> productsToShow = new List<Product>() ;


        // search products
        if (!String.IsNullOrWhiteSpace(searchQuery))
        {
            productsToShow = products.Where(p => p.Title.Contains(searchQuery.ToLower())).ToList();

        }
        else
        {
            productsToShow = products;
        }



        // filter
        if (filterByCat != null)
        {
            int filterByCatId = Int32.Parse(filterByCat);
            List<ProductCategory> pcat = _dbContex.ProductCategories.ToList();
            List<Product> productsToShowFiltered = new List<Product>();

            List<ProductCategory> filteredproducts = pcat.FindAll(c => c.CategoryId == filterByCatId);
            foreach (var pc in filteredproducts)
            {
                Product product = productsToShow.Find(p => p.ProductId == pc.ProductId);
                productsToShowFiltered.Add(product);
            }
            productsToShow = productsToShowFiltered;

        }


        // sortiranje
        // Title asc/desc, price asc/desc
        switch (orderBy)
        {
            case 1: productsToShow = productsToShow.OrderBy(p => p.Title).ToList(); break;
            case 2: productsToShow = productsToShow.OrderByDescending(p => p.Title).ToList(); break;
            case 3: productsToShow = productsToShow.OrderBy(p => p.Price).ToList(); break;
            case 4: productsToShow = productsToShow.OrderByDescending(p => p.Price).ToList(); break;
            default: break;

        }

        return View(productsToShow);
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

