using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineMovieTicketBooking.Data;
using OnlineMovieTicketBooking.Models;

namespace OnlineMovieTicketBooking.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private UserManager<IdentityUser> _usermanager;
        private ApplicationDbContext _context;

        public CartController(ApplicationDbContext context, UserManager<IdentityUser> usermanager)
        {
            _context = context;
            _usermanager = usermanager;
        }
        public IActionResult Index()
        {
            var item = _context.Cart.Where(a => a.UserId == _usermanager.GetUserId(HttpContext.User)).ToList();
            ViewBag.count = item.Count;
            return View(item);
        }

        public IActionResult cartEmpty()
        {
            TempData["cartempty"] = "Empty Cart";
            return View();
        }
        [HttpGet]
        public IActionResult proceed(Cart cart)
        {
            var CartList = _context.Cart.Where(a => a.UserId == _usermanager.GetUserId(HttpContext.User)).ToList();
            if (CartList.Count == 0)
            {
                return RedirectToAction("cartEmpty", "Cart");
            }
            else
            {
                return View(CartList);
            }
        }

        public IActionResult Delete(int id)
        {
            _context.Cart.Remove(_context.Cart.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult BookTicket(Cart cart)
        {
            var CartList = _context.Cart.Where(a => a.UserId == _usermanager.GetUserId(HttpContext.User)).ToList();
            if (CartList.Count == 0)
            {
                return RedirectToAction("cartEmpty", "Cart");
            }
            else
            {
                foreach(var tickets in CartList)
                {
                    var ticket = new BookingTable
                    {
                        SeatNo = tickets.SeatNo,
                        UserId = tickets.UserId,
                        Datetopresent = tickets.date,
                        MovieDetailsId = tickets.MovieId,
                        Amount = tickets.Amount
                    };
                    _context.BookingTable.Add(ticket);
                    _context.Cart.Remove(_context.Cart.Find(tickets.Id));
                    _context.SaveChanges();
                    
                }
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult OrderDetails()
        {
            var orderdetails = _context.BookingTable.Where(a => a.UserId == _usermanager.GetUserId(HttpContext.User)).ToList();
            return View(orderdetails);
        }
    }
}
