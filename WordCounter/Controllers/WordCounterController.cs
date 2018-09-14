using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
    public class WordCounterController : Controller
    {
        [HttpGet("/words")] 
        public ActionResult Index()
        {
            List<RepeatCounter> allItems = RepeatCounter.GetAll();           
            return View();
        }
        [HttpGet("/words/new")]
        public ActionResult CreateWord()
        {
            return View();
        }
        [HttpPost("/words")]
        public ActionResult CreateCount()
        {
            RepeatCounter userInput = new RepeatCounter(Request.Form["new-word"], Request.Form["new-sentence"]);
            userInput.CountWord();
            userInput.Save();
            List<RepeatCounter> allItems = RepeatCounter.GetAll();
            return View("Index", allItems);
        }
    }

}