using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HuntController : Controller
    {
        // 
        // GET: /Hunt/

        public string Index()
        {
            return "Enter your hunting details here";
        }

        // will eventually be
        // POST: /EnterHunt/ 

        public string EnterHunt(string location, string species, int confirmedShot = 1)
        {
            return HtmlEncoder.Default.Encode($"So you shot {confirmedShot} {species} at {location} ");
        }
    }
}