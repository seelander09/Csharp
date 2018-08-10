using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        private YourContext _context;

        public HomeController(YourContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            // grabs all reviews from database

            return View();
        }
        [HttpPost]
        [Route("reviews")]
        public IActionResult Reviews(Review review) // You dont have to write out the constructor its implied here
        {
            _context.Add(review);
            _context.SaveChanges();
            System.Console.WriteLine(review);
            // grabs all reviews from database
            List<Review> AllReviews = _context.reviews.ToList();
            ViewBag.AllReviews = AllReviews;
            System.Console.WriteLine("**************** Inside Review function ****************");



            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
