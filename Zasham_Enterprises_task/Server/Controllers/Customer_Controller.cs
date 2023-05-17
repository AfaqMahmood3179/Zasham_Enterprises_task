using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Zasham_Enterprises_task.Shared;

namespace Zasham_Enterprises_task.Server.Controllers
{

    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class Customer_Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("Customers_List")]
        public IEnumerable<Customer> Fetch_All_Customers()
        {
            IList<Customer> list = new List<Customer>();
            list.Add(new Customer { Customer_name = "Afaq Mehmood", Customer_email = "19101001-050@uskt.edu.pk", Customer_address = "Sambrial, Sialkot", Customer_phone = "+923107194924" });
            return list;
        }
    }
}
