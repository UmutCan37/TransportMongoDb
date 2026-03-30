using Microsoft.AspNetCore.Mvc;

namespace TransportMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
