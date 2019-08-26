using Onion.Core.DomainService;
using Onion.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Infrastructure.Data.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        public IMovieRepository Create(Movie movie)
        {
            movie.Id = FakeDB.MovieId++;
            FakeDB.MovieTable.Add(movie);
            return movie;
        }

        public List<Movie> ReadAll()
        {
            return FakeDB.MovieTable;
        }
    }
}
