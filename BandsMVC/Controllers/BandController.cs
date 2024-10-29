using Microsoft.AspNetCore.Mvc;

namespace BandsMVC.Controllers
{
    public class BandController : Controller
    {
        static DataService _dataService = new DataService();

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/Details/{id}")]
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
