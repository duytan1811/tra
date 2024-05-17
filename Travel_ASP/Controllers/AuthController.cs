using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Travel_ASP.Common;
using Travel_ASP.Models;
using Travel_ASP.ViewModels.Auth;

namespace Travel_ASP.Controllers
{
    [Route("admin")]
    public class AuthController : BaseController
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        public AuthController(SignInManager<User> signInManager,
            UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            this.CurrentUser = new CurrentUser();
            var result = await this._signInManager.PasswordSignInAsync(dto.Username, dto.Password, false, true);
            if (result.IsLockedOut)
            {
                return RedirectToAction("Login","Auth");
            }

            if (!result.Succeeded)
            {
                return RedirectToAction("Login", "Auth");
            }
            var user = await this._userManager.FindByNameAsync(dto.Username);
            if (user != null)
            {
                this.CurrentUser.UserId = user.Id;
                this.CurrentUser.Username = user.UserName;
            }

            return RedirectToAction("Index", "Dashboard");
        }
    }
}
