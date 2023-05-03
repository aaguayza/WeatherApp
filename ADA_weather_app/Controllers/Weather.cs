using Microsoft.AspNetCore.Mvc;

namespace ADA_weather_app.Controllers
{
    public class Weather : Controller
    {
        public IActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Search(string searchTerm)
        {
            return View();
        }
    }
}
