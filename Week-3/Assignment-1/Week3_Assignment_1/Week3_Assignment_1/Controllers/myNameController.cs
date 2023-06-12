using Microsoft.AspNetCore.Mvc;
using Week3_Assignment_1.Models;

namespace Week3_Assignment_1.Controllers
{
    public class myNameController : Controller
    {
        public IActionResult Index()
        {
            var cookieName = Request.Cookies["name"];
            if (cookieName == null)
            {
                return RedirectToAction("TrackName", "TrackName");
            }

            TrackNameModel model = new TrackNameModel
            {
                Name = cookieName
            };
            return View(model);
        }
    }
}
