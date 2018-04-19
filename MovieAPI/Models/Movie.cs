using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearReleased { get; set; }
        public string Tagline { get; set; }
        public decimal Rating { get; set; }

    }
}