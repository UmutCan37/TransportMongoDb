using Microsoft.AspNetCore.Mvc;

namespace TransportMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultMobileMenuComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
