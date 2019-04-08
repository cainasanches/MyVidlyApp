using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyVidlyApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Movie> _lstMovie { get; set; }

    }
}