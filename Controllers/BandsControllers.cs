using Microsoft.AspNetCore.Mvc;
using BandsMVC.Models;

namespace BandsMVC.Controllers
{
    public class BandsController : Controller
    {
        DataService dataService = new DataService();
        [HttpGet("")]
        public IActionResult Index()
        {
            Band[] bandList = dataService.GetAllBands();
            return View(bandList);
        }

        [HttpGet("details/{Id}")]
        public IActionResult Details()
        {
            return View();
        }
    }
}