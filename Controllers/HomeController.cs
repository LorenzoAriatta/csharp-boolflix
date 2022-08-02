using csharp_boolflix.Data;
using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace csharp_boolflix.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly BoolflixContext _db;

        public HomeController(ILogger<HomeController> logger, BoolflixContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            Random random = new Random();

            int contents = _db.VideoContents.Count();

            Movie movieRNG = (Movie)_db.VideoContents.Skip(random.Next(contents)).Include("Profiles").First();

            ViewData["Jumbo"] = movieRNG;

            return View(movieRNG);
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