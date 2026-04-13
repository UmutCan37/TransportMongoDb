using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransportMongoDb.Services.TestimonialService;

namespace TransportMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _DefaultTestimonialComponentPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value =await _testimonialService.GetAllTestimonialsAsync();
            return View(value);
        }
    }
}
