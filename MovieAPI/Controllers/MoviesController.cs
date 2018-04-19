using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieAPI.Data;
using MovieAPI.Models;

namespace MovieAPI.Controllers
{
    public class MoviesController : ApiController
    {
        public IEnumerable<Movie> Get()
        {
            var db = new MoviesContext();
            return db.Movies.ToList();
        }
        public IHttpActionResult Post(string name)
        {
            var newMovie = new Movie
            {
                Name = name
            };
            var db = new MoviesContext();
            db.Movies.Add(newMovie);
            db.SaveChanges();
            return Ok (newMovie);
        }
    }
}
