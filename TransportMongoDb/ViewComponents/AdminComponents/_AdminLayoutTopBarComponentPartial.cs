using Microsoft.AspNetCore.Mvc;

namespace TransportMongoDb.ViewComponents.AdminComponents
{
    public class _AdminLayoutTopBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
