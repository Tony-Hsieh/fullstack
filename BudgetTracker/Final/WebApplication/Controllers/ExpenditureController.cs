using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;

namespace WebApplication.Controllers
{
    public class ExpenditureController : Controller
    {
        private readonly IExpenditureService _expenditureService;
        private readonly ICurrentUserService _currentUser;
        public ExpenditureController(IExpenditureService expenditureService, ICurrentUserService currentUser)
        {
            _expenditureService = expenditureService;
            _currentUser = currentUser;
        }
        [HttpGet]
        public async Task<IActionResult> ListExpenditureInfo() {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            var res=await _expenditureService.ListAllExpenditures();
            return View(res);
        }
        [HttpGet]
        public IActionResult ModifyExpenditure() {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ModifyExpenditure(ExpenditureRequestModel request)
        {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            await _expenditureService.UpdateExpenditure(request);
            return RedirectToAction("index", "user");
        }
        [HttpGet]
        public IActionResult AddExpenditure() {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddExpenditure(ExpenditureRequestModel request) {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            await _expenditureService.AddExpenditure(request);
            return RedirectToAction("index", "user");
        }

        [HttpGet]
        public IActionResult DeleteExpenditure() {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> DeleteExpenditure(ExpenditureRequestModel request) {
            if (_currentUser.IsAuthenticated == false)
            {
                return RedirectToAction("Login", "Account");
            }
            await _expenditureService.DeleteExpenditure(request);
            return RedirectToAction("index", "user");
        }
        [HttpGet]
        public async Task<IActionResult> DeleteExpenditureInTable(int Id) {
            var request = new ExpenditureRequestModel() {
                Id = Id
            };
            await _expenditureService.DeleteExpenditure(request);
            return RedirectToAction("ListExpenditureInfo");
        }

    }
}
