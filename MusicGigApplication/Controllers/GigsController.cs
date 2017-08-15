using Microsoft.AspNet.Identity;
using MusicGigApplication.Models;
using MusicGigApplication.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MusicGigApplication.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();        
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigFormViewModel viewModel)
        {
            //Read artist and genre from database.

            var gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = viewModel.DateTime,
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };
            //Track with Entity Framework
            _context.Gigs.Add(gig);
           
            //EF will generate an SQL statement and execute it against our database.
            _context.SaveChanges();

            //Redirect user to the home page.  In the next use case, we will replace Home Page with a list of all upcoming gigs in the database.
            return RedirectToAction("Index", "Home");
        }
    }
}