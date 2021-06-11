using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineMovieTicketBooking.Data;
using OnlineMovieTicketBooking.Models;
using OnlineMovieTicketBooking.Models.ViewModels;

namespace OnlineMovieTicketBooking.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        int count = 1;
        bool flag = true;
        private ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;
        private UserManager<IdentityUser> _usermanager;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, UserManager<IdentityUser> usermanager)
        {
            _usermanager = usermanager;
            _logger = logger;
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var getMovieList = _context.MovieDetails.ToList();
            return View(getMovieList);
        }
       [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_context.MovieDetails.Find(id));
        }
     
        [HttpPost]
        public async Task<IActionResult> Edit(MovieDetails md)
        {
            _context.Update(md);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            try
            {
                var movie = _context.MovieDetails.Where(r => r.Id.Equals(id)).FirstOrDefault();

                if (movie == null)
                    throw new Exception("No Movie Found");

                _context.MovieDetails.Remove(movie);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return new JsonResult(e);
            }
        }
        [HttpGet]
        public IActionResult BookNow(int Id)
        {
            BookNowViewModel vm = new BookNowViewModel();
            var item = _context.MovieDetails.Where(a => a.Id == Id).FirstOrDefault();
            vm.Movie_Name = item.Movie_Name;
            vm.Movie_Date = item.DateAndTime;
            vm.MovieId = Id;
            
            string[] SeatArr = { "1", "2", "3", "4", "5" ,"6", "7", "8", "9", "10"};
            var CartSeatArr = _context.Cart.Where(a => a.MovieId == Id).Select(a => a.SeatNo).ToArray();
            if (CartSeatArr.Length != 0)
            {
                var Seat = SeatArr.Except(CartSeatArr);
                ViewBag.Seat = Seat;
            }
            else
            {
                var BookedTicket = _context.BookingTable.Where(a => a.MovieDetailsId == Id).Select(a => a.SeatNo).ToArray();
                var Seat = SeatArr.Except(BookedTicket);
                ViewBag.Seat = Seat;
            }
            
            return View(vm);
        }

        [HttpPost]
        public IActionResult BookNow(BookNowViewModel vm)
        {
            List<BookingTable> booking = new List<BookingTable>();
            List<Cart> carts = new List<Cart>();
            string seatno = vm.SeatNo;
            int movieId = vm.MovieId;

            var item = new Cart
            {
                Amount = 150,
                MovieId = vm.MovieId,
                UserId = _usermanager.GetUserId(HttpContext.User),
                date = vm.Movie_Date,
                SeatNo = seatno

            };
            _context.Cart.Add(item);
            _context.SaveChanges();
            TempData["Success"] = "Seat Is Booked, Check Your Cart";


            /*string[] seatnoArray = seatno.Split(',');
            count = seatnoArray.Length;
            if(checkseat(seatno,movieId) == false)
            {
                foreach (var item in seatnoArray)
                {
                    carts.Add(new Cart { Amount = 150, MovieId = vm.MovieId, UserId = _usermanager.GetUserId(HttpContext.User), date = vm.Movie_Date, SeatNo = item });
                }
                foreach(var item in carts)
                {
                    _context.Cart.Add(item);
                    _context.SaveChanges();

                }
                TempData["Success"] = "Seat Is Booked, Check Your Cart";
            }
            else
            {
                TempData["seatnomsg"] = "Please Change Your Seat No.";
            }*/
            return RedirectToAction("BookNow");
        }

        private bool checkseat(string seatno, int movieid)
        {
            string seats = seatno;
            string[] seatreserve = seats.Split(',');
            var seatnolist = _context.BookingTable.Where(a => a.MovieDetailsId == movieid).ToList();

            foreach (var item in seatnolist)
            {
                string alreadybook = item.SeatNo;
                foreach (var item1 in seatreserve)
                {
                    if (item1 == alreadybook)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            if (flag == false)
                return true;
            else
                return false;
        }

        [HttpPost]
        public IActionResult checkseat(DateTime Movie_Date, BookNowViewModel booknow)
        {
            string seatno = string.Empty;
            var movielist = _context.BookingTable.Where(a => a.Datetopresent == Movie_Date).ToList();
            if (movielist!=null)
            {
                var getseatno = movielist.Where(b => b.MovieDetailsId == booknow.MovieId).ToList();
                if(getseatno!=null)
                {
                    foreach(var item in getseatno)
                    {
                        seatno = seatno + " " + item.SeatNo.ToString();
                    }
                    TempData["SNO"] = "Already Booked " + seatno;
                }
            }
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
