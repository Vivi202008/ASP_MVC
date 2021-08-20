using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAlong_Empty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Wei Cao";
            ViewBag.Info = "This is my world, a small world.";
            return View();
        }

        public IActionResult About()
        {
            ViewBag.Name = "Wei Cao";
            ViewBag.Info = "Because I had worked with students in high school for a long time, so I am very serious and careful to deal with different situations, and I am good at working with my colleagues. My professional life leads to me being sensitive to wrong and abnormal situations. When I face a problem, I get excited and eager to solve it. I was eager for different challenges, so I chose a new career path. Even though I am no longer young, I have a responsible attitude, long-term patience and perseverance. ";
            ViewBag.Education = "Programmering.NET – Lexicon Yrkesutbilding i Väst ";
            ViewBag.EducationPeriod = "8 JUN 2021 – Now ";
            ViewBag.Education1 = "Software Tester – EC utbilding";
            ViewBag.EducationPeriod1 = "1 Sept  2019 – 18 Dec 2020";

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.LinkedIn = "https://www.linkedin.com/in/weicao2020";
            ViewBag.Tele = "07366666";
            ViewBag.Email = "2925771815@qq.com";         

            return View();
        }

        public IActionResult Myprojects()
        {
            ViewBag.Github = "https://github.com/Vivi202008";
            ViewBag.Sokoban = "https://github.com/Vivi202008/sokoban_Game";
            ViewBag.Myweb = "https://github.com/Vivi202008/MyWebb";
            ViewBag.VendingMachine = "https://github.com/Vivi202008/VendingMachineApp_N";
            ViewBag.Mvc = "https://github.com/Vivi202008/MVC_ASP";
            ViewBag.HangMan = "https://github.com/Vivi202008/HangmanGame";
            return View();
        }

    }
}
