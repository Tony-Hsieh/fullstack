using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.ServiceInterfaces;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieShopMVC.Models;

namespace MovieShopMVC.Controllers
{
    public class HomeController : Controller
    {
        //1. *** Constructor Injection 99.99
        //2. Method Injection
        //3. Property Injection

        //readonly can only be modified in constructor or declaration
        private readonly IMovieService _movieService;

        //Dependency Injection (see HomeController)
        public HomeController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public async Task<IActionResult> Index()
        {
            //7.12
            var movies = await _movieService.GetTopRevenueMovies();

            //3 ways to send the dat from Controller/action to VIew
            //1. Models(strongly typed models) ***
            //2. ViewBag
            //3. ViewData

            //viewbag is a dynamic class
            ViewBag.MoviesCount = movies.Count();
            return View(movies);


            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //GET localhost:5001/Home/GetHighestGrossingMovies

        [HttpGet]
        public IActionResult GetHighestGrossingMovies()
        {
            return View();
            // return View("privacy"); use view name return view

            //return view => _ViewStart => _Layout(with header and footer)
            //  => Renderbody => views inside /home
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
