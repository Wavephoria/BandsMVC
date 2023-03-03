using Microsoft.AspNetCore.Mvc;
using BandsMVC.Models;

namespace BandsMVC.Controllers
{
    public class BandsController : Controller
    {
        DataService dataService = new DataService();
        [HttpGet(""), HttpGet("Index")]
        public IActionResult Index()
        {
            Band[] bandList = dataService.GetAllBands();
            return View(bandList);
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            Band band = dataService.GetBandById(id);
            return View(band);
        }
    }
}