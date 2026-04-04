using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransportMongoDb.Services.OfferService;

namespace TransportMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultOfferComponentPartial : ViewComponent
    {
        private readonly IOfferService _offerService;

        public _DefaultOfferComponentPartial(IOfferService offerService)
        {
            _offerService = offerService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values=await _offerService.GetAllOfferAsync();
            return View(values);
        }
    }
}
