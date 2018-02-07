using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidak.Models;
using System.Data.Entity;

namespace Vidak.Controllers
{
    public class MoviesController : Controller
    {
	    private ApplicationDbContext _context;

	    public MoviesController()
	    {
		    _context = new ApplicationDbContext();
	    }

		protected override void Dispose(bool disposing)
		{
			_context.Dispose();
		}

		// GET: Movies
		public ViewResult Index()
        {
	        var movies = _context.Movie.Include(m => m.GenreTypes).ToList();

	        return View(movies);
        }

		public ActionResult Detail(int id)
		{
			var movie = _context.Movie.Include(m => m.GenreTypes).SingleOrDefault(m => m.Id == id);

			if (movie == null) return HttpNotFound();

			return View(movie);
		}
		public ActionResult ByReleaseDate(int year, int month)
		{

			return Content(year + "/" + month);
		}
    }
}