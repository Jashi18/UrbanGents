using Microsoft.AspNetCore.Mvc;
using UrbanGents.Data;
using UrbanGents.Models;

namespace UrbanGents.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var CategoryList = _context.Categories.ToList();
            return View(CategoryList);
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            foreach (var names in _context.Categories) 
            { 
                if (obj.Name == names.Name)
                {
                    ModelState.AddModelError("name", "That Category already exists");
                }
            }
            if (ModelState.IsValid) {
                _context.Categories.Add(obj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
