using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileUpload;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineMovieTicketBooking.Data;
using OnlineMovieTicketBooking.Models;
using OnlineMovieTicketBooking.Models.ViewModels;

namespace OnlineMovieTicketBooking.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;
        private UploadInterface _upload;

        public AdminController(ApplicationDbContext context, UploadInterface upload)
        {
            _upload = upload;
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IList<IFormFile> files, MovieDetailViewmodel vmodel, MovieDetails movie)
        {
            movie.Movie_Name = vmodel.Name;
            movie.Movie_Description = vmodel.Description;
            movie.DateAndTime = vmodel.DateofMovie;

            foreach(var item in files)
            {
                movie.MoviePicture = "~/uploads/" + item.FileName.Trim();
            }
            _upload.uploadfilemultiple(files);
            _context.MovieDetails.Add(movie);
            _context.SaveChanges();
            TempData["Success"] = "Save Your Movie";
            return RedirectToAction("Create", "Admin");
        }
        [HttpGet]
        public IActionResult CheckBookSeat()
        {
            var getBookingTable = _context.BookingTable.ToList().OrderByDescending(a => a.Datetopresent);
            return View(getBookingTable);
        }
        [HttpGet]
        public IActionResult GetUserDetails()
        {
            var getUserTable = _context.Users.ToList();
            return View(getUserTable);
        }
    }
}
