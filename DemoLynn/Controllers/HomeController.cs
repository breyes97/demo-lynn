using DemoLynn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;


namespace DemoLynn.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Dictionary<int, string> typeOfService = new Dictionary<int, string>()
            {
                { 1, "Telefonía Móvil" },

            };

            //using (var context = new DEMOLYNNContext())
            //{
            //    var _typeOfService = context.Businesses.ToList();
            //}

            SelectList selTypeOfService = new SelectList(typeOfService, "Key", "Value");
            ViewBag.TypeOfService = selTypeOfService;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
