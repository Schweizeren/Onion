using Onion.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Core.DomainService
{
    public interface IMovieRepository
    {
        List<Movie> ReadAll();

        IMovieRepository Create(Movie movie);
    }
}
