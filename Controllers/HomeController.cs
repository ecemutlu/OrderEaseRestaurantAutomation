using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OrderEaseRestaurantAutomation.Models;
using static OrderEaseRestaurantAutomation.Models.DummyDataRepos;

namespace OrderEaseRestaurantAutomation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static User User { get; } = new User
        {
            username = "ecemutlu",
            password = "ece123"
        };
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(string username,string password)
        {
            if (username == User.username && password == User.password)
            {
                // Successful login, you can redirect or perform other actions
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Invalid login, display an error message
                ModelState.AddModelError("LoginError", "Invalid username or password");
                return View();
            }

        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Card()
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
