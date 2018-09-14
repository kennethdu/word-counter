using Microsoft.AspNetCore.Mvc;
using LeapYears.Models;
using System.Collections.Generic;

namespace LeapYear.Controllers
{
    public class LeapYearController : Controller
    {
        [HttpGet("/years")]
        public ActionResult Index()
        {
            List<LeapYearChecker> allYears = LeapYearChecker.GetAll();
            return View();
        }
        [HttpGet("/years/new")]
        public ActionResult Year()
        {
            return View();
        }
        // [HttpPost("/years")]
        // public ActionResult Create()
        // {
        //     LeapYearChecker userYear = new LeapYearChecker(Request.Form["new-year"]);
        //     userYear.IsLeapYear();
        //     userYear.Save();
        //     List<LeapYearChecker> allYears = LeapYearChecker.GetAll();
        //     return View("Index", allYears);
        // }
    }

}