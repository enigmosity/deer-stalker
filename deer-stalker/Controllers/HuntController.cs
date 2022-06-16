using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using deer_stalker.Models;

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

            var hunt = new Hunt(){
                Location = location,
                Species = species,
                ConfirmedShot = confirmedShot,
            };

            ViewData["Hunt"] = hunt;

            return View(hunt);
        }
    }
}