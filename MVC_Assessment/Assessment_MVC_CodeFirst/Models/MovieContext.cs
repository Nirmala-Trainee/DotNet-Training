using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CodeFirst.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("name= connectstr") { }

        public DbSet<Movie> movie { get; set; }
    }
}