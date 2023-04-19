using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWebShop.Services;
using DemoWebShop.Services.Cart;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWebShop.Controllers
{
    public class OrderController : Controller
    {
        public const string sessionCartKey = "_cart";

        // GET: /<controller>/
        public IActionResult Checkout()
        {
            // 1. pronadji sesiju i provjeri ako postoji nešto u košarici
            List<CartItem> cartItems = HttpContext.Session.GetCartItemFromJson(sessionCartKey);
            if (cartItems.Count() <= 0)
            {
               return RedirectToAction(nameof(Index), "Home");
            }
            // def ViewBag
            ViewBag.CheckMessages = TempData["CheckoutMessages"] as string ?? "";



            return View(cartItems);
        }

        // TODO create order


    }
}

