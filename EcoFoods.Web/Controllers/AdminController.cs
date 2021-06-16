using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using EcoFoods.DomainEntities;
using EcoFoods.Infrastructure.DataAccess;

namespace EcoFoods.Web.Controllers
{
    
    public class AdminController : Controller
    {
        /*
        private readonly ProductDBContext _db;

        public AdminController(ProductDBContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Product> ProductList = _db.Products;
            return View(ProductList);
        }

        */

        private readonly IRepository _db;
        public AdminController(ProductDBContext context, IRepository repository)
        {
            _db = repository;
        }

        public async Task<IActionResult> IndexAsync()
        {
            IEnumerable<Product> ProductList = await _db.SelectAll<Product>();
            return View(ProductList);
        }

    }
}
