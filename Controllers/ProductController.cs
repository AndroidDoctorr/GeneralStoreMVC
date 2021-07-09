using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GS_MVC.Models;
using GS_MVC.Data;

namespace GS_MVC.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db) : base()
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var products = _db.Products.Select(p => new ProductListItem()
            {
                ProductId = p.Id,
                Name = p.Name,
                Price = p.Price,
            });
            return View(products);
        }
    }
}
