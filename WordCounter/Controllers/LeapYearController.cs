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
        [HttpPost("/years/new")]
        public ActionResult Year()
        {
            LeapYearChecker checkedYear = new LeapYearChecker(Request.Form["new-year"]);
            return View(checkedYear);
        }
    }

}