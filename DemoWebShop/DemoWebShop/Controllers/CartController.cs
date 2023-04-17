using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace DemoWebShop.Controllers
{
    public class CartController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /<controller>/
        public IActionResult TestSession()
        {
            HttpContext.Session.SetString("sessionString", "vrijednost za string");

            ViewBag.ReadSessionString = HttpContext.Session.GetString("sessionString");

            HttpContext.Session.SetString("sessionString", "vrijednost DRUGA za string");
          


            return View();
        }


    }
}

