using Microsoft.AspNetCore.Mvc;

namespace CelilCavus.GreenHosting.Controllers
{
    public class AdminPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}