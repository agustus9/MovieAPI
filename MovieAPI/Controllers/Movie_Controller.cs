using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MovieAPI.Models;
using MovieAPI.Data;

namespace MovieAPI.Controllers
{
    public class Movie_Controller : ApiController
    {
        public IHttpActionResult Post(Movie data)
        {
            var db = new MoviesContext();
            db.Movies.Add(data);
            db.SaveChanges();
            return Ok(data);
        }
    }
}
