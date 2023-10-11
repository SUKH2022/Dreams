using Microsoft.AspNetCore.Mvc;

namespace Dreams.Controllers{
    public class CategoryProductsController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}