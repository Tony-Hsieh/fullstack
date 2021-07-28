using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;

namespace WebApplication.Controllers
{
    public class IncomeController : Controller
    {
        private readonly IIncomeService _incomeService;
        private readonly ICurrentUserService _currentUser;
        public IncomeController(IIncomeService incomeService, ICurrentUserService currentUser)
        {
            _incomeService = incomeService;
            _currentUser = currentUser;
        }
        [HttpGet]
        public async Task<IActionResult> ListIncomeInfo() {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            var res =await _incomeService.ListAllIncomes();
            return View(res);
        }
        [HttpGet]
        public  IActionResult AddIncome() {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddIncome(IncomeRequestModel request) {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            await _incomeService.AddIncome(request);
            return RedirectToAction("index","user");
        }
        [HttpGet]
        public IActionResult ModifyIncome()
        {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ModifyIncome(IncomeRequestModel request)
        {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            await _incomeService.UpdateIncome(request);
            return RedirectToAction("index", "user");
        }
        [HttpGet]
        public IActionResult DeleteIncome()
        {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteIncome(IncomeRequestModel request)
        {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            await _incomeService.DeleteIncome(request);
            return RedirectToAction("index", "user");
        }
        [HttpGet]
        public async Task<IActionResult> DeleteIncomeInTable(int id) {
            var request = new IncomeRequestModel()
            {
                Id = id
            };
            await _incomeService.DeleteIncome(request);
            return RedirectToAction("ListIncomeInfo");
        }

    }
}
