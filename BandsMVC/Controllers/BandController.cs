using Microsoft.AspNetCore.Mvc;
using BandsMVC.Models;

namespace BandsMVC.Controllers
{
    public class BandController : Controller
    {
        static DataService _dataService = new DataService();

        [HttpGet("")]
        public IActionResult Index()
        {
            var model = _dataService.GetAllBands();
            return View(model);
        }
        [HttpGet("/Details/{id}")]
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
