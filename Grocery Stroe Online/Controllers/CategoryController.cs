using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grocery_Stroe_Online.Data;
using Grocery_Stroe_Online.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Grocery_Stroe_Online.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            if (_db.Categories.Count() > 0)
            {
                IEnumerable<Category> categories = _db.Categories.ToList();
                return View(categories);
            }

            return NotFound();
        }
        //GET Create
        public IActionResult Create()
        {
            return View();
        }
        // POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }


    }
}
