using ECommerceProject.Models;
using ECommerceProject.Persistence;
using ECommerceProject.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceProject.Controllers
{
    public class OrderController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private AppDbContext _context;
        private readonly IHttpContextAccessor _accessor;
        

        public OrderController(UserManager<ApplicationUser> userManager, AppDbContext context, IHttpContextAccessor accessor)
        {
            this.userManager = userManager;
            _context = context;
            _accessor = accessor;
        }

        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        //POST Checkout action method

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(Order anOrder)
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if (products != null)
            {
                foreach (var product in products)
                {
                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.FoodId = product.Id;
                    
                    anOrder.OrderDetails.Add(orderDetails);
                }
            }
            var crntUserName = userManager.GetUserId(HttpContext.User);

            anOrder.OrderNo = GetOrderNo();
            anOrder.UserName = crntUserName;
            _context.Orders.Add(anOrder);
            await _context.SaveChangesAsync();
            HttpContext.Session.Set("products", new List<Products>());
            return View();
        }


        public string GetOrderNo()
        {
            int rowCount = _context.Orders.ToList().Count() + 1;
            return rowCount.ToString("000");
        }

        [Authorize(Roles ="Admin")]
        public IActionResult ViewOrder()
        {
            var data = _context.Orders.ToList();
            return View(data);
        }
        [Authorize]
        public IActionResult MyOrder()
        {
            var crntUserName = userManager.GetUserId(HttpContext.User);

            var data = _context.Orders.Where(_ => _.UserName == crntUserName).ToList();
            return View(data);
        }

       
       // [ActionName("Detail")]
        public ActionResult OrderDetail(int? id)
        {

           
            var products =  _context.OrderDetails.Where(o=>o.OrderId==id).Select(p => p.Product).ToList();

        
            return View(products);
        }


        public ActionResult GetOrderDetail(int? id)
        {


            var products = _context.OrderDetails.Where(o => o.OrderId == id).Select(p => p.Product).ToList();
            //var order = _context.Orders.Where(o => o.Id == id);
            //ViewBag.orders = "order";
            //ViewBag.product = "products";


            return View(products);
        }


        public ActionResult DeleteOrder(int id)
        {


            var products = _context.Orders.Find(id);
            _context.Orders.Remove(products);
            _context.SaveChanges();
            //var order = _context.Orders.Where(o => o.Id == id);
            //ViewBag.orders = "order";
            //ViewBag.product = "products";


            return RedirectToAction("ViewOrder");
        }

    }
}
