using DemoLynn.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Linq;


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
            var typeOfService = new Dictionary<Guid, string>();

            try
            {
                using (var context = new DEMOLYNNContext())
                {
                    typeOfService = context.Businesses.ToDictionary(b => b.Id, b => b.Name);

                    //var test = context.Businesses.FirstOrDefault();

                    //var er = test.Name;

                    //var test2 = context.Businesses.OrderBy(b => b.Name).LastOrDefault();
                    //var test3 = context.Businesses.Where(b => b.Name == "HOPSPITGAL");

                    //var hospitales = test3.Where(h => h.Name.Contains("Pinar"));



                    //var test4 = context.Businesses.Where(b => b.Name.StartsWith("H")).ToList();

                    //var y = test4.Where(h => h.Name.Contains("Pinar"));

                    //var test5 = context.Businesses.Where(b => b.Name.Contains("H")).Select(c => c.Id).ToList();

                }
            }
            catch
            {}
            

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
