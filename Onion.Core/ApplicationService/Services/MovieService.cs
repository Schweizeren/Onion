using Onion.Core.DomainService;
using Onion.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Core.ApplicationService.Services
{
    public class MovieService : IMovieService
    {

        private IMovieRepository _MovieRepo;

        public MovieService(IMovieRepository MovieRepo)
        {
            this._MovieRepo = MovieRepo;
        }

        public Movie Add(Movie movie)
        {
            return movie;
        }

        public List<Movie> FindAllMovies()
        {
            return this._MovieRepo.ReadAll();
        }

        public Movie FindSingle(int id)
        {
            return this._MovieRepo.Create
             
        }
    }
}
