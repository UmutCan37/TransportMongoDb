using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransportMongoDb.Services.GetInTouchService;

namespace TransportMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultGetInTouchComponentPartial : ViewComponent
    {
        private readonly IGetInTouchService _getInTouchService;

        public _DefaultGetInTouchComponentPartial(IGetInTouchService getInTouchService)
        {
            _getInTouchService = getInTouchService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _getInTouchService.GetAllGetInTouchAsync();
            return View(values);
        }
    }
}
