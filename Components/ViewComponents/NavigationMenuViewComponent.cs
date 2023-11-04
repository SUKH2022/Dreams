using Microsoft.AspNetCore.Mvc;
using Dreams.Models;

namespace Dreams.Components.ViewComponents
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var menuItems = new List<MenuItem>
        {
            // Categories
            new MenuItem { Controller = "Home", Action = "Index", Label = "Home" },
            // new MenuItem { Controller = "Categories", Action = "Index", Label = "Categories", DropdownItems = new List<MenuItem> {
            //     new MenuItem { Controller = "Categories", Action = "Index", Label = "List" },
            //     new MenuItem { Controller = "Categories", Action = "Create", Label = "Create" },
            // } },
            // // CategoryProducts
            // new MenuItem { Controller = "CategoryProducts", Action = "Index", Label = "Products", DropdownItems = new List<MenuItem> {
            // //     new MenuItem { Controller = "CategoryProducts", Action = "Index", Label = "List" },
            //     new MenuItem { Controller = "CategoryProducts", Action = "Create", Label = "Create" },
            // } },
            new MenuItem { Controller = "Categories", Action = "Index", Label = "Categories" },
            new MenuItem { Controller = "CategoryProducts", Action = "Index", Label = "Products" },
            new MenuItem { Controller = "Carts", Action = "Index", Label = "View My Cart" },
            new MenuItem { Controller = "Briefs", Action = "Index", Label = "Briefs" },
            new MenuItem { Controller = "Home", Action = "Contact", Label = "Contact" },
            new MenuItem { Controller = "Home", Action = "Privacy", Label = "Privacy" },
        };
            return View(menuItems);
        }
    }
}