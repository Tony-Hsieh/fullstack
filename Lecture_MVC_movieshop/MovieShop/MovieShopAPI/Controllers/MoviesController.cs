using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.ServiceInterfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MovieShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService)
        {

        }

        //attribute based routing
        [HttpGet]
        [Route("toprevenue")]
        public async Task<IActionResult> GetTopRevenueMovies()
        {
            var movies = await _movieService.GetTopRevenueMovies();

            // always need to send json data HTTP Status Codes
            //OK, NotFound from Controllerbase
            if (!movies.Any())
            {
                return NotFound() 
            }

            return Ok(movies);
            //NewtonSoft Json
            // in .Net Core 3.1> System.Text.json
        }

    }
}