using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace WebApplication.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        public AccountController(IUserService UserService) {
            _userService = UserService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserRequestModel request)
        {
            if (!ModelState.IsValid) {
                return View();
            }
            var user = await _userService.Login(request);
            if (user == null)
            {
                // wrong password
                ModelState.AddModelError(string.Empty, "Email or password wrong");
                return View();
            }
            var claims = new List<Claim>
            {
                 new Claim(ClaimTypes.Email, user.Email),
                 new Claim(ClaimTypes.Name, user.FullName),
                 new Claim(ClaimTypes.NameIdentifier, user.Id.ToString())
            };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
            return RedirectToAction("index","Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Register() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserRequestModel request) {
            if (!ModelState.IsValid) {
                return View();
            }
            request.JoinOn = DateTime.Now;
            var res =await _userService.RegisterUser(request);
            return RedirectToAction("Login");
        }
    }
}
