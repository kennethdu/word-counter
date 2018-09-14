using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
    public class ParcelController : Controller
    {
        [HttpGet("/parcels")]
        public ActionResult Index()
        {
            List<Parcel> allItems = new List<Parcel> { };
            return View();
        }
        [HttpGet("/parcels/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
        [HttpPost("/parcels")]
        public ActionResult Create()
        {
            Parcel userParcel = new Parcel(Request.Form["new-width"], Request.Form["new-length"], Request.Form["new-heighth"], Request.Form["new-weight"]);
            userParcel.Save();
            userParcel.costToShip();
            List<Parcel> allItems = Parcel.GetAll();
            return View("Index", allItems);
        }
    }
}
