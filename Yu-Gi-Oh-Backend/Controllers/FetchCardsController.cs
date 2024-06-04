using Microsoft.AspNetCore.Mvc;

namespace Yu_Gi_Oh_Backend.Controllers
{
    public class FetchCardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
