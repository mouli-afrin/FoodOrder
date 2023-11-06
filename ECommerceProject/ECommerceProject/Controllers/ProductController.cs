using ECommerceProject.Models;
using ECommerceProject.Persistence;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProject.Controllers
{
    public class ProductController : Controller
    {
        private AppDbContext _context;
        private IHostingEnvironment _env;

        public ProductController(AppDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        [Authorize(Roles ="Admin")]
        public IActionResult Index()
        {
            var data = _context.Products.Include(p => p.ProductTypes).ToList();
            return View(data);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Index(decimal? lowamount, decimal? largeamount)
        {
            var data = _context.Products.Include(p => p.ProductTypes).Where(c => c.Price >= lowamount && c.Price <= largeamount).ToList();
            if (lowamount == null && largeamount == null)
            {
                data = _context.Products.Include(p => p.ProductTypes).ToList();
            }

            return View(data);
        }



        public IActionResult Create()
        {
            var data = _context.ProductTypes.ToList();
            ViewData["FoodTypeId"] = new SelectList(data, "Id", "FoodType");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Products products, IFormFile image)
        {
            if (ModelState.IsValid)
            {

                var searchProduct = _context.Products.FirstOrDefault(C => C.Name == products.Name);
                if (searchProduct != null)
                {
                    ViewBag.message = "Already Exist";
                    var data = _context.ProductTypes.ToList();
                    ViewData["ProductId"] = new SelectList(data, "Id", "FoodType");
                    return View(products);
                }

                if (image != null)
                {
                    var name = Path.Combine(_env.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "Images/" + image.FileName;
                }

                _context.Products.Add(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(products);
        }

        public ActionResult Edit(int? id)
        {
            var data = _context.ProductTypes.ToList();
            ViewData["productTypeId"] = new SelectList(data, "Id", "ProductType");

            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Products.Include(c => c.ProductTypes).FirstOrDefault(c => c.Id == id);

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Products products, IFormFile image)
        {
            if (ModelState.IsValid)
            {
                if (image != null)
                {
                    var name = Path.Combine(_env.WebRootPath + "/Images", Path.GetFileName(image.FileName));
                    await image.CopyToAsync(new FileStream(name, FileMode.Create));
                    products.Image = "Images/" + image.FileName;
                }

                _context.Products.Update(products);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(products);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _context.Products.Include(c => c.ProductTypes).FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }






        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = _context.Products.Include(c => c.ProductTypes).Where(c => c.Id == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _context.Products.FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            _context.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
