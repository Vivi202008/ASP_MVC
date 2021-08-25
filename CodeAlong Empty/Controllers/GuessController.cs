using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAlong_Empty.Models;
using Microsoft.AspNetCore.Http;

namespace CodeAlong_Empty.Controllers
{
    public class GuessController : Controller
    {
        [HttpGet]
        public IActionResult Guess()
        {
            ViewBag.Info = "Guess a number (1-100)";
            ViewBag.Msg = " ";
            ViewBag.Times = "";

           Random rnd = new Random();
            HttpContext.Session.SetInt32("Number", rnd.Next(1, 101));
            HttpContext.Session.SetInt32("Times", 0);
            return View();
        }

        [HttpPost]
        public IActionResult Guess(int guess)
        {
            int times = (int)HttpContext.Session.GetInt32("Times");
            times++;
            HttpContext.Session.SetInt32("Times", times);
            ViewBag.Times = "You guess "+times+" times.";

            int number = (int)HttpContext.Session.GetInt32("Number");
            if (guess < number)
            {
                ViewBag.Msg = guess+" is too small!";
                return View();
            }
            else if (guess > number)
            {
                ViewBag.Msg = guess+ " is too big!";
                return View();
            }
            else
            {
                ViewBag.Msg = guess + " is right.  You win!!!Hurry!!";
                Random rnd = new Random();
                HttpContext.Session.SetInt32("Number", rnd.Next(1, 101));
                HttpContext.Session.SetInt32("Times", 0);
                return View();
                
            }
        }

    }
}
