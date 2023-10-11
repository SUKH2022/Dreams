
using Microsoft.AspNetCore.Mvc;

namespace Dreams.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            List<Dictionary<string, object>> data = new()
            {
                new() {{"Id",1}, {"Name", "RoboHealth Solutions"}},
                new() {{"Id",2}, {"Name", "RoboHealth Solutions"}},
                new() {{"Id",3}, {"Name", "RoboHealth Solutions"}},
            };
            return View(data);
        }
    }
}