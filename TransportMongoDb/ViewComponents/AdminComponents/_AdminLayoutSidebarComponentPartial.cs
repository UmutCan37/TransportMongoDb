using Microsoft.AspNetCore.Mvc;

namespace TransportMongoDb.ViewComponents.AdminComponents
{
    public class _AdminLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
