using ASPInl_1.Models;
using ASPMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASPInl_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IEnumerable<ProductModel> products = new List<ProductModel>();


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                products = await client.GetFromJsonAsync<IEnumerable<ProductModel>>($"https://localhost:7264/api/Products");
            }

            return View(products);
        }

        public async Task<IActionResult> PowerSupplies()
        {
            using (var client = new HttpClient())
            {
                products = await client.GetFromJsonAsync<IEnumerable<ProductModel>>($"https://localhost:7264/api/Products");
            }

            return View(products);
        }

        public async Task<IActionResult> Printers()
        {
            using (var client = new HttpClient())
            {
                products = await client.GetFromJsonAsync<IEnumerable<ProductModel>>($"https://localhost:7264/api/Products");
            }

            return View(products);
        }

        public async Task<IActionResult> Details(int id)
        {
            ProductModel product = new();

            using (var client = new HttpClient())
            {
                product = await client.GetFromJsonAsync<ProductModel>($"https://localhost:7264/api/Products/{id}");
            }

            return View(product);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}