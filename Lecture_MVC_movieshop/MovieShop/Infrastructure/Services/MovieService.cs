using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class MovieService : IMovieService
    {

        //7/15
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public async Task<List<MovieCardResponseModel>> GetTopRevenueMovies()
        {
            var movies = await _movieRepository.GetHighest30GrossingMovies();

            //Convert task<list<Movie>> to Task<List<MovieCardResponseModel>>
            var movieCards = new List<MovieCardResponseModel>(); 
            foreach (var movie in movies)
            {
                movieCards.Add(new MovieCardResponseModel
                {
                    Id = movie.Id,
                    Budget = movie.Budget.GetValueOrDefault(),
                    PosterUrl = movie.PosterUrl,
                    Title = movie.Title
                });
            }

            return movieCards;
        }

        public async Task<MovieDetailsResponseModel> GetMovieDetails(int id)
        {
            var movie = await _movieRepository.GetByIdAsync(id);
            var c = movie.MovieCasts;
            var movieDetails = new MovieDetailsResponseModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                PosterUrl = movie.PosterUrl,
                BackdropUrl = movie.BackdropUrl,
                Rating = movie.Rating.GetValueOrDefault(),
                Overview = movie.Overview,
                Tagline = movie.Tagline,
                Budget = movie.Budget.GetValueOrDefault(),
                Revenue = movie.Revenue.GetValueOrDefault(),
                ImdbUrl = movie.ImdbUrl,
                TmdbUrl = movie.TmdbUrl,
                ReleaseDate = movie.ReleaseDate.GetValueOrDefault(),
                RunTime = movie.RunTime,
                Price = movie.Price,

            };

            if (movie.Favorites != null)
                movieDetails.FavoritesCount = movie.Favorites.Count;

            movieDetails.Casts = new List<CastResponseModel>();
            foreach (var Cast in movie.MovieCasts)
            {
                movieDetails.Casts.Add(
                    new CastResponseModel
                    {
                        Id = Cast.CastId,
                        Name = Cast.Cast.Name,
                        Gender = Cast.Cast.Gender,
                        TmdbUrl = Cast.Cast.TmdbUrl,
                        ProfilePath = Cast.Cast.ProfilePath,
                        Character = Cast.Character,
                    }
                );
            }

            movieDetails.Genres = new List<GenreModel>();
            foreach (var genre in movie.Genres)
            {
                movieDetails.Genres.Add(
                    new GenreModel
                    {
                        Id = genre.Id,
                        Name = genre.Name
                    }
                );
            }

            return movieDetails;
        }

        //7.12
        //public List<MovieCardResponseModel> GetTopRevenueMovies()
        //{
        //    var movies = new List<MovieCardResponseModel> {

        //        new MovieCardResponseModel {Id = 1, Title = "Avengers: Infinity War", Budget = 1200000},
        //        new MovieCardResponseModel {Id = 2, Title = "Avatar", Budget = 1200000},
        //        new MovieCardResponseModel {Id = 3, Title = "Star Wars: The Force Awakens", Budget = 1200000},
        //        new MovieCardResponseModel {Id = 4, Title = "Titanic", Budget = 1200000},
        //        new MovieCardResponseModel {Id = 5, Title = "Inception", Budget = 1200000},
        //        new MovieCardResponseModel {Id = 6, Title = "Avengers: Age of Ultron", Budget = 1200000},
        //        new MovieCardResponseModel {Id = 7, Title = "Interstellar", Budget = 1200000},
        //        new MovieCardResponseModel {Id = 8, Title = "Fight Club", Budget = 1200000},
        //    };

        //    return movies;
        //}

    }

}
// method (int x, IMovieService service)

// method (4, new MovieService())