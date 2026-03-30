using Microsoft.AspNetCore.Mvc;

namespace TransportMongoDb.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
