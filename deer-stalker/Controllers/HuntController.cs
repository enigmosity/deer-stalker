using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HuntController : Controller
    {
        // 
        // GET: /Hunt/

        public IActionResult Index()
        {
            return View();
        }

        // will eventually be
        // POST: /EnterHunt/ 

        public IActionResult EnterHunt(string location, string species, int confirmedShot = 1)
        {
            // return HtmlEncoder.Default.Encode($"So you shot {confirmedShot} {species} at {location} ");

            ViewData["Message"] = $"So you shot {confirmedShot} {species} at {location}";

            return View();
        }
    }
}