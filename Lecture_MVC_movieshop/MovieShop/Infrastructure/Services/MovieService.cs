using System;
using System.Collections.Generic;
using ApplicationCore.Models;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        public List<MovieCardResponseModel> GetTopRevenueMovie()
        {
            throw new NotImplementedException();
        }
    }
}

// method (int x, IMovieService service)

// method (4, new MovieService())