using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razor_PagesMovie.Models;

namespace Razor_PagesMovie.Data
{
    public class Razor_PagesMovieContext : DbContext
    {
        public Razor_PagesMovieContext (DbContextOptions<Razor_PagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Razor_PagesMovie.Models.Movie> Movie { get; set; }
    }
}
