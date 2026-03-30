using Microsoft.AspNetCore.Mvc;

namespace TransportMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
