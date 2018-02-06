using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidak.Models;

namespace Vidak.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Index()
        {
	        var movies = GetMovies();

	        return View(movies);
        }

		public ActionResult Detail(int id)
		{
			var movie = GetMovies().SingleOrDefault(m => m.Id == id);

			if (movie == null) return HttpNotFound();

			return View(movie);
		}
		public ActionResult ByReleaseDate(int year, int month)
		{

			return Content(year + "/" + month);
		}

	    private IEnumerable<Movie> GetMovies()
	    {
			return new List<Movie>()
			{
				new Movie {Id = 1, Name="Shrek!"},
				new Movie {Id = 2, Name="Titanic!"}
			};
	    }
    }
}