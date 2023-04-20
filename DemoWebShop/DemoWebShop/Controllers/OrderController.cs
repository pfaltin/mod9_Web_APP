using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoWebShop.Areas.Identity.Data;
using DemoWebShop.Data;
using DemoWebShop.Models;
using DemoWebShop.Services;
using DemoWebShop.Services.Cart;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWebShop.Controllers
{
    public class OrderController : Controller
    {
        // kluc sesije  za kosaricu
        public const string sessionCartKey = "_cart";

        // objekt za pristup bazi
        private readonly ApplicationDbContext _dbContext;

        // objekt za pristup prijavljenom korisniku
        private readonly UserManager<ApplicationUser> _userManager;

        public OrderController
        (
            ApplicationDbContext dbContext,
            UserManager<ApplicationUser> user
        )
        {
            _dbContext = dbContext;
            _userManager = user;
        }



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
        [HttpPost]
        public IActionResult CreateOrder(Order newOrder)
        {
            // ? kosarica je pazna
            List<CartItem> cart = HttpContext.Session.GetCartItemFromJson(sessionCartKey);
            if (cart.Count <= 0)
            {
                return RedirectToAction(nameof(Index), "Home");
            }

            // ? model validan

            var modelErrors = new List<string>();
            if (ModelState.IsValid)
            {
                //true - sve OK

                newOrder.Total = cart.Sum(item => item.GetTotal());

                // dobijamo prijavljenog korisnika
                newOrder.UserId = _userManager.GetUserId(User);

                _dbContext.Orders.Add(newOrder);
                _dbContext.SaveChanges();


                foreach (var cartItem in cart)
                {
                    OrderItem newOrderItem = new OrderItem()
                    {
                        OrderId = newOrder.OrderId,
                        ProductId = cartItem.Product.ProductId,
                        Price = cartItem.Product.Price,
                        Quantity = cartItem.Quatity,
                        Total = cartItem.GetTotal()

                    };
                    _dbContext.OrderItems.Add(newOrderItem);

                }
                _dbContext.SaveChanges();
                HttpContext.Session.SetCartObjectAsJSON(sessionCartKey,"");
                TempData["ThankYoyMessage"] = "Thanks, for order!";
                return RedirectToAction(nameof(Index), "Home");



            }
            else
            {
                // false - neki je problem prisutan
                foreach(var modelState in ModelState.Values)
                {
                    foreach(var error in modelState.Errors)
                    {
                        modelErrors.Add(error.ErrorMessage);
                    }
                }
                TempData["CheckoutMessages"] = String.Join("<br />", modelErrors);
                return RedirectToAction("Checkout");
            }

            // pohrana u bazu, čišćenje košarice, preusmeravanje,...



           // return View();
        }


    }
}

