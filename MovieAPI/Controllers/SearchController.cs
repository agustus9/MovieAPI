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
    public class SearchController : ApiController
    {
        public IEnumerable<Movie> Get(string name)
        {
            var db = new MoviesContext();
            return db.Movies.Where(x => x.Name.Contains(name)).ToList();
        }
    }
}
