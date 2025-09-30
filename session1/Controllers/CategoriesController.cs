using Microsoft.AspNetCore.Mvc;
using session1.Data;

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
    }
}
