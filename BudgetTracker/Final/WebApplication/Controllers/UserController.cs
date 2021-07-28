using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;

namespace WebApplication.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly ICurrentUserService _currentUser;
        public UserController(IUserService userService,ICurrentUserService currentUser)
        {
            _userService = userService;
            _currentUser = currentUser;
        }
        [HttpGet]
        public IActionResult Index()
        {
            if (_currentUser.IsAuthenticated == false) {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> ViewUserInfo(){
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            var res=await _userService.ListAllUsers();
            return View(res);
        }
        [HttpGet]
        public  IActionResult ModifyUserInfo() {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ModifyUserInfo(UserRequestModel request)
        {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            if (!ModelState.IsValid) {
                return View();
            }
            await _userService.UpdateUser(request);
            return Redirect("Index");
        }
        [HttpGet]
        public IActionResult DeleteUser() {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            return View(); 
        }
        [HttpPost]
        public async Task<IActionResult> DeleteUser(UserRequestModel request)
        {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            await _userService.DeleteUser(request);
            return Redirect("Index");
        }
        [HttpGet]
        public async Task<IActionResult> DeleteUserInTable(int Id) 
        {
            var request = new UserRequestModel()
            {
                Id = Id
            };
            await _userService.DeleteUser(request);
            return Redirect("ViewUserInfo");
        }
        [HttpGet]
        public IActionResult AddUser() {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            return RedirectToAction("Register", "Account");
        }
        [HttpGet]
        public async Task<IActionResult> UserDetails(int id) {
           var res= await _userService.GetUserDetailById(id);
           return View(res);
        }
        
    }
}
