﻿using Onion.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.Core.ApplicationService
{
    public interface IMovieService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Movie> FindAllMovies();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Movie FindSingle();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        Movie Add(Movie movie);

    }
}
