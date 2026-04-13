using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransportMongoDb.Services.HowItWorkServices;

namespace TransportMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultHowItWorksComponentPartial : ViewComponent
    {
        private readonly IHowItWorkService _howItWorkService;

        public _DefaultHowItWorksComponentPartial(IHowItWorkService howItWorkService)
        {
            _howItWorkService = howItWorkService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value= await _howItWorkService.GetAllHowItWorkAsync();
            return View(value);
        }
    }
}
