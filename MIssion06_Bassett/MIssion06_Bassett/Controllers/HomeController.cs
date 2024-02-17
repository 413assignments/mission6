using Microsoft.AspNetCore.Mvc;
using MIssion06_Bassett.Models;
using System.Diagnostics;

namespace MIssion06_Bassett.Controllers
{
    public class HomeController : Controller
    {
        private MoviesContext _context;

        public HomeController(MoviesContext x)
        {
            _context = x;
        }







        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AddEntry()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEntry(Movie entry)
        {
            _context.Movies.Add(entry);
            _context.SaveChanges();

            return View("GetToKnow");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
