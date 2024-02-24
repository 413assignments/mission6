using Microsoft.AspNetCore.Mvc;
using MIssion06_Bassett.Models;
using System.Diagnostics;
using System.Linq;




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
            // Load the Categories table into the ViewBag (for the dropdown).
            ViewBag.categories = _context.Categories.OrderBy(x => x.categoryName).ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddEntry(Movie entry)
        {
            _context.Movies.Add(entry);
            _context.SaveChanges();

            // Load the GetToKnow page.
            return View("GetToKnow");
        }

        public IActionResult Database ()
        {

            ViewBag.categoryMappings = new Dictionary<string, string>();
           
            // Load data from the Categories table into the dictionary, such that the categoryIDs are the keys, and the categoryNames are the values.
            // This will make it easier to display categoryNames in the view, since the Movies records will only have categoryID.
            foreach (Category c in _context.Categories.OrderBy(x => x.categoryID).ToList())
            {
                ViewBag.categoryMappings[c.categoryID.ToString()] = c.categoryName;
            }

            // Grab the Movies table and pass it into the view.
            List<Movie> movies = _context.Movies.ToList();

            return View(movies);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            // Load the Categories table into the ViewBag (for the dropdown).
            ViewBag.categories = _context.Categories.OrderBy(x => x.categoryID).ToList();

            // Load the Movie the user wants to edit into the ViewBag, so the view can have its input fields pre-populated with the existing data.
            ViewBag.nowEditing = _context.Movies.Where(x => x.movieID == id).ToList()[0];

            return View();
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedMovie)
        {
            _context.Update(updatedMovie);
            _context.SaveChanges();

            return RedirectToAction("Database");
        }

        public IActionResult Delete(int id)
        {
            // Grab the record we want to delete using the movieID.
            Movie toDelete = _context.Movies.First(x => x.movieID == id);

            // NUKE IT!
            _context.Movies.Remove(toDelete);
            _context.SaveChanges();

            // Redirect to the data page.
            return RedirectToAction("Database");
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
