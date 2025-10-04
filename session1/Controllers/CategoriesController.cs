using Microsoft.AspNetCore.Mvc;
using session1.Data;
using session1.Models;

namespace session1.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ViewResult Index()
        {
            var categories = context.Categories.ToList();
            return View("Index", categories);
        }
        public ViewResult Details(int id)
        {
            var category = context.Categories.Find(id);
            return View("Details", category);
        }

        public ViewResult Create()
        {
            return View("Create", new Category());
        }

        public IActionResult Store(Category request)
        {
            if (ModelState.IsValid) 
            {
                context.Categories.Add(request);
                context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View("Create", request);
        }
        public RedirectToActionResult Delete(int id)
        {
            var category = context.Categories.Find(id);
            context.Categories.Remove(category);
            context.SaveChanges();
            
            return RedirectToAction("Index");
        }

        public ViewResult Update(int id)
        {
            var category = context.Categories.Find(id);
            return View("Update", category);
        }

        public IActionResult Edit(Category request)
        {
            context.Categories.Update(request);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
