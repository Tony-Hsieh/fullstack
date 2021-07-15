using System;
using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IMovieRepository
    {
        List<Movie> GetHighestGrossingMovies();
        //10 methods
    }
}
