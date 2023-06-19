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
        public IActionResult SignIn(AddUserViewModel addUserViewModel)
        {
            var user = new User { Email = addUserViewModel.Email, Password = addUserViewModel.Password };
            bool isUserExist = mvcDbContext.Users.Any(user => user.Email == addUserViewModel.Email && user.Password == addUserViewModel.Password);
            if (isUserExist)
            {
                return RedirectToAction("member");
            }
            TempData["Msg"] = "帳號或密碼錯誤";
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Member()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(AddUserViewModel addUserRequest)
        {
            if(ModelState.IsValid)
            {
                bool emailExist = mvcDbContext.Users.Any(user => user.Email == addUserRequest.Email);

                if(emailExist)
                {
                    TempData["Msg"] = "帳號已存在";
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
            TempData["Msg"] = "註冊資料有誤";
            return RedirectToAction("Index", "Home");
        }
    }
}
