using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
    public class LeapYearController : Controller
    {
        [HttpGet("/years")]
        public ActionResult Index()
        {
            List<LeapYearChecker> allYears = LeapYearChecker.GetAll();
            return View(allYears);
        }
        [HttpGet("/years/new")]
        public ActionResult Year()
        {
            LeapYear checkedYear = new LeapYear(Request.Form["new-year"]);
            return View(checkedYear);
        }
    }

}