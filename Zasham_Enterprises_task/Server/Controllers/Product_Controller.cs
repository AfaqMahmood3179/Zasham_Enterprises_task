using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Zasham_Enterprises_task.Shared;

namespace Zasham_Enterprises_task.Server.Controllers
{

    [Authorize]
    [ApiController]
    [Route("[controller]")]

    public class Product_Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet("Products_List")]
        public IEnumerable<Product> FetchAllProducts()
        {
            IList<Product> list = new List<Product>();
            list.Add(new Product { product_id = "P1", Product_name = "Watch", Product_price = 3550.89f , Product_description = "A branded valueable watch"});
            return list;
        }
    }
}
