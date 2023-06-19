using Assignment_1.Data;
using Assignment_1.Models;
using Assignment_1.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Controllers
{
    public class UserController : Controller
    {
        private readonly MvcDbContext mvcDbContext;
        public UserController(MvcDbContext mvcDbContext)
        {
            this.mvcDbContext = mvcDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn()
        {
            if (true)
            {
                return RedirectToAction("member");
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Member()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult SignUp()
        //{
        //    if (true)
        //    {
        //        return RedirectToAction("member");
        //    }
        //    return RedirectToAction("Index", "Home");
        //}

        [HttpPost]
        public async Task<IActionResult> SignUp(AddUserViewModel addUserRequest)
        {
            bool emailExist = mvcDbContext.Users.Any(user => user.Email == addUserRequest.Email);

            if(emailExist)
            {
                //ViewBag.SignInError = "block";
                return RedirectToAction("Index", "Home");
            }

            var user = new User()
            {
                Id = Guid.NewGuid(),
                Email = addUserRequest.Email,
                Password = addUserRequest.Password
            };

            await mvcDbContext.Users.AddAsync(user);
            await mvcDbContext.SaveChangesAsync();
            return RedirectToAction("Member");
        }
    }
}
