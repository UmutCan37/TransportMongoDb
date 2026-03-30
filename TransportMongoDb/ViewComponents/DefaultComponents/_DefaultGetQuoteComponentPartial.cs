using Microsoft.AspNetCore.Mvc;

namespace TransportMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultGetQuoteComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
