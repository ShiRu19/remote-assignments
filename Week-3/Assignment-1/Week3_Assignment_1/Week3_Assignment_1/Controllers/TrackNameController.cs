using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Week3_Assignment_1.Models;

namespace Week3_Assignment_1.Controllers
{
    public class TrackNameController : Controller
    {
        public IActionResult TrackName()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index(string? name)
        {
            if (name == null)
            {
                return RedirectToAction("TrackName", "TrackName");
            }

            var cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTime.Now.AddDays(1);
            cookieOptions.Path = "/";

            Response.Cookies.Append("name", name, cookieOptions);

            return RedirectToAction("Index", "myName");
        }
    }
}
