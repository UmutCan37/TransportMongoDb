using Microsoft.AspNetCore.Mvc;

namespace TransportMongoDb.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
