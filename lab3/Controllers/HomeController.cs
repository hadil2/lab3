using Microsoft.AspNetCore.Mvc;
using Lab3.Models;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SongForm() => View();

        [HttpPost]
        public IActionResult Sing()
        {
            HttpContext.Session.SetString("numBottles", Request.Form["numBottles"]);

            return View();
        }

        public IActionResult CreatePerson() => View();

        [HttpPost]
        public IActionResult DisplayPerson(Person person)
        {
            if (person.FirstName == null)
            {
                return View("~/Views/Home/Error.cshtml");
            }
            // you will complete this
            return View(person);
        }
        public IActionResult Error()
        {
            return View();
        }



    }
}
