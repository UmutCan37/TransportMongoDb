using Microsoft.AspNetCore.Mvc;

namespace TransportMongoDb.ViewComponents.AdminComponents
{
    public class _AdminLayoutScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
