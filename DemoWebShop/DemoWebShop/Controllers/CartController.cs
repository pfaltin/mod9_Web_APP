using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWebShop.Data;
using DemoWebShop.Services;
using DemoWebShop.Services.Cart;
using Microsoft.AspNetCore.Mvc;


namespace DemoWebShop.Controllers
{
    public class CartController : Controller
    {


        private readonly ApplicationDbContext _dbContex;

        public const string sessionCartKey = "_cart";
        

        // dependecy incjection

        public CartController( ApplicationDbContext DbContex)
        {
            
            _dbContex = DbContex;

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            // provjeri kosaricu iz sesije
            List<CartItem> cart = HttpContext.Session.GetCartItemFromJson(sessionCartKey);
            //
            ViewBag.CartErrorMassage = TempData["CartErrorMassage"] as string ?? "";

            return View(cart);
        }

        // GET: /<controller>/
        public IActionResult TestSession()
        {
            HttpContext.Session.SetString("sessionString", "vrijednost za string");

            ViewBag.ReadSessionString = HttpContext.Session.GetString("sessionString");

            HttpContext.Session.SetString("sessionString", "vrijednost DRUGA za string");
          


            return View();
        }

        // add to cart
        [HttpPost]
        public IActionResult AddToCart(int productID, decimal quantity)
        {
            if(quantity <= 0)
            {
                return RedirectToAction(nameof(Index), "Home");
            }

            // kosarica je prazna
            // kreiraj klsu CartItem i popuni je


            // kosarica nije prazna
            // proizvod postoji
            // novi proizvod ne postoji

            // provjeri postoji li Product
            var findProduct = _dbContex.Products.Find(productID);
            if(findProduct== null) return RedirectToAction(nameof(Index), "Home");

            // provjeri sesiju

            List<CartItem> cart = HttpContext.Session.GetCartItemFromJson(sessionCartKey);

            // uvjeti za koristenje kosarice
            if (cart.Count == 0)
            {
                // sto ako zeli vise nego ima na stnju
                if(quantity > findProduct.InStock)
                {
                    TempData["CartErrorMessage"] = $"Nema dovoljno na stanju{findProduct.InStock}";
                    return RedirectToAction(nameof(Index), "Home");
                }
                // novi objekt CartItem
                CartItem newCartItem = new CartItem() { Product = findProduct, Quatity = quantity};
                cart.Add(newCartItem);
                // azuriranje sesije za kosaricu
                HttpContext.Session.SetCartObjectAsJSON(sessionCartKey, cart);


            }
            else
            {

            }

            return RedirectToAction(nameof(Index), "Home");
            //return View();
        }


    }
}

