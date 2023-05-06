using Microsoft.AspNetCore.Mvc;

namespace CelilCavus.GreenHosting.Controllers
{
    public class AboutUsController:Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}