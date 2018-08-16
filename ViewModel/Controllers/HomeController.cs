using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string msg = "I like Coding in Csharp";
            return View("Index", msg);
        }

        [Route("about")]
        public IActionResult About()
        {
            int[] numbers = new int[]{1,2,3,4,5};

            return View(numbers);
        }

        public new IActionResult User()
        {
            User user = new User()
            {
                FirstName = "Lord",
                LastName = "Vador"
            };

            return View(user);
        }
        [Route("contact")]
        public IActionResult Contact()
        {
           List<User> allUsers = new List<User>();
            User NewGuy = new User("",""),
            User NewGuy1 = new User("",""),
            User NewGuy2 = new User("","")


            return View("Numbers", Number);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
