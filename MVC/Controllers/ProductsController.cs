using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    // CLR Create objects of this class to handle requests

    //[Route("[controller]")]
    public class ProductsController : Controller
    {
        #region Setion 2-MVC

        // Url : BaseURL/Products/Search?Term=Iphone&MinPrice=1000&page=2`

        public IActionResult Search(ProductFilter productFilter)
        {
            return Json(new
            {
                Term = productFilter.Term,
                MinPrice = productFilter.MinPrice,
                page = productFilter.page
            });     
        }



        #endregion













        #region
        //// Functions --> Methods --> Actions -> Endpoint -> Apis 


        //// BaseULR/Products/GetProductById

        //// Non-Static (Object Memeber Methods)
        //public Product GetProductById(int id)
        //{
        //    // Logic --> Connection To DB --> To Get Data

        //    return new Product() { Id = 1, Name = "Iphone 15 Pro Max", Price = 20 };
        //}


        // Actions : Public Non-Static (Object Memeber Function) Methods
        // Action Results : Built-in Datatype Used As Return Type For Actions


        // BaseURL/Products/GetProducts
        //[HttpPost]
        //public List<Product> GetProducts()
        //{
        //    // Logic

        //    return new List<Product>()
        //    {
        //        new Product(){Id = 1, Name = "P1", Price = 100},
        //        new Product(){Id = 2, Name = "P2", Price = 130},
        //        new Product(){Id = 3, Name = "P3", Price = 110},
        //    };
        //}


        //// BaseURL/Products/GetProductById
        //[HttpGet]
        //public Product GetProductById(int id)
        //{
        //    // Logic --> Connection To DB --> To Get Data
        //    return new Product() { Id = 1, Name = "Iphone 15 Pro Max", Price = 20 };
        //}
        #endregion





        [HttpGet("P")]
        public IActionResult GetProducts()
        {
            return new JsonResult(new List<Product>()
            {
                new Product(){Id = 1, Name = "P1", Price = 100},
                new Product(){Id = 2, Name = "P2", Price = 130},
                new Product(){Id = 3, Name = "P3", Price = 110},
            });
        }



        // BaseURL/Products/Index
        [HttpGet]
        public IActionResult Index()
        {
            return new ViewResult(); 
        }



        [HttpGet] // BASEURL/Products/DownloadFile
        public IActionResult DownloadFile()
        {
            var bytes = System.IO.File.ReadAllBytes("wwwroot/files/");
            return new FileContentResult(bytes, "application/txt");
        }


        [HttpGet] // BASEURL/Products/RedirectToUrl
        public IActionResult RedirectToUrl()
        {
            return Redirect("https://www.google.com");
        }



        [HttpGet]
        public IActionResult RedirectAction()
        {
            return RedirectToAction("RedirectToUrl", "Products", null);
        }


        // ActionResult
        public IActionResult Test(int id)
        {
            if (id == 1)
                return View();
            else if (id == 2)
                return Json(new Product() { Id = 1, Name = "Iphone 18 Pro Max", Price = 1200000 });
            else if (id == 3)
                return Redirect("https://www.instagram.com");
            else
                return View();
        }

    }
}
