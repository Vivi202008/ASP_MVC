using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeAlong_Empty.Models;

namespace CodeAlong_Empty.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult FeverCheck()
        {
            ViewBag.Info = "Input your tempareture";
            return View();
        }


        [HttpPost]
        public IActionResult FeverCheck(string temp, string unit)
        {

            try
            {
                ViewBag.Info = "Input your tempareture";
                ViewBag.Msg = Doctorhelper.Diagnose(temp, unit);
                return View();
            }
            catch
            {
                return View();
            }

        }
    }
}
