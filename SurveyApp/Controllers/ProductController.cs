using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EcoFoods.DomainEntities;
using EcoFoods.Infrastructure.DataAccess;

namespace EcoFoods.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepository _db;
        public ProductController(ProductDBContext context, IRepository repository)
        {
            _db = repository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> ProductList = await _db.SelectAll<Product>();
            return View(ProductList);
        }

        public IActionResult Add()
        {

            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Product product)
        {
            if (ModelState.IsValid)
            {
                await _db.CreateAsync<Product>(product);
                return RedirectToAction("Index", "Admin");
            }
            return View(product);

        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var product = await _db.SelectById<Product>(id);

            if (product == null)
            {
                return NotFound();
            }


            await _db.DeleteAsync<Product>(product);
            return RedirectToAction("Index", "Admin");


        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var product = await _db.SelectById<Product>(id);

            if (product == null)
            {
                return NotFound();
            }


            return View(product);

        }

        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {
            if (ModelState.IsValid)
            {
                await _db.UpdateAsync<Product>(product);
                return RedirectToAction("Index", "Admin");
            }


            return RedirectToAction("Welcome", "Home");

        }

    }
}
