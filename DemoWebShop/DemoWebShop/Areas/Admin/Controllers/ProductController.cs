using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoWebShop.Models;
using DemoWebShop.Data;
using System.Drawing;

namespace DemoWebShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Product
        public async Task<IActionResult> Index()
        {
              return _context.Products != null ? 
                          View(await _context.Products.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Products'  is null.");
        }

        // GET: Admin/Product/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Product/Create
        public IActionResult Create()
        {
            //1. korak slanje poruke u view
            ViewBag.ErrorMessage = TempData["ErrorMessage"] as string ?? "";
            return View();
        }

        // POST: Admin/Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,Title,Description,InStock,Price,Image,Sku")] Product product, int[] categoryIds, IFormFile image )
        {
            // 1. korak validacije ulaza 
            if (categoryIds.Length == 0 || categoryIds == null)
            {
                // izbaci poruku
                // TempData je kolekcija koja kreira kretkorocne poruke u sesiji izmedju dva kontrolera
                TempData["ErrorMessage"] = "Odaberi kategoriju";
                return RedirectToAction(nameof(Create));
            }

            //2, korak upiši u tablicu i upiši u agregaciju -ProductCategorys


            if (ModelState.IsValid)
            {
                // 2.1 pokusaj spreminti sliku i spremi je u svojstvo product.image
                try
                {
                    // pr1
                    var imageName = image.FileName.ToLower();

                    //var imageNameExt = Path.GetExtension(image.FileName);
                    //var imageName = DateTime.Now.ToString("yyyymmdd")+ imageNameExt;


                    // odabri putanje pohran
                    // rez: /wwwroot/images/products/naziv-jpg
                    var saveImgPath = Path.Combine(Directory.GetCurrentDirectory(), "./wwwroot/images/products/", imageName);

                    // kreiraj mape
                    Directory.CreateDirectory(Path.GetDirectoryName(saveImgPath));
                    // kopiranje slike
                    using (var stream = new FileStream(saveImgPath , FileMode.Create))
                    {
                        
                           image.CopyTo(stream);
                    }
                    product.Image = imageName;
                }
                catch
                {
                    TempData["ErrorMessage"] = "Odaberi foto";
                    return RedirectToAction(nameof(Create));
                }
                _context.Add(product);
                await _context.SaveChangesAsync();

                foreach(var catId in categoryIds)
                {
                    ProductCategory productCategory = new ProductCategory();
                    productCategory.CategoryId = catId;
                    productCategory.ProductId = product.ProductId;

                    _context.ProductCategories.Add(productCategory);
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            await _context.SaveChangesAsync();
            return View(product);
        }

        // GET: Admin/Product/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Admin/Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,Title,Description,InStock,Price,Image,Sku")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Admin/Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Products == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Products'  is null.");
            }
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                _context.Products.Remove(product);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
          return (_context.Products?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}
