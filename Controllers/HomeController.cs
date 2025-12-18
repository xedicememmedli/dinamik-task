using front_to_back_code.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using static front_to_back_code.Models.Products;

namespace front_to_back_code.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Product> Products = new List<Product>()
{
    new Product
    {
        Id=1,
        Title="Title 1",
        Discount=20,
        Image="1-1-524x617.png"
    },
    new Product
    {
        Id=2,
        Title="Title 2",
        Discount=20,
        Price = 49.90,
        Image="1-1-524x617.png"
    },
     new Product
     {
        Id=3,
        Title="Title 3",
        Discount=20,
        Price = 49.90,
        Image="1-1-524x617.png"
    
      },
     new Product
     {
         Id =4,
         Title = "Title 3",
         Discount = 20,
         Price = 49.90,
         Image = "1-1-524x617.png"
      },
     new Product
     {
        Id=5,
        Title="Title 3",
        Discount=20,
        Price = 49.90,
        Image="1-1-524x617.png"
     },
     new Product
     {
        Id=6,
        Title="Title 3",
        Discount=20,
         Price = 49.90,
        Image="1-1-524x617.png"
     },
     new Product
     {
        Id=7,
        Title="Title 3",
        Discount=20,
        Price = 49.90,
        Image="1-1-524x617.png"
     },
     new Product
     {
        Id=8,
        Title="Title 3",
        Discount=20,
        Price = 49.90,
        Image="1-1-524x617.png"
     },
     new Product
     {
        Id=9,
        Title="Title 3",
        Discount=20,
        Price = 49.90,
        Image="1-1-524x617.png"
     },
     new Product
     {
        Id=10,
        Title="Title 3",
        Discount=20,
        Price = 49.90,
        Image="1-1-524x617.png"
    }
};
            HomeVM homeVM = new HomeVM
            {

               Products= Products.ToList()
            };
            return View(homeVM);
        }
    }
}
