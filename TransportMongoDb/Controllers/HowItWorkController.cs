using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransportMongoDb.Dtos.HowItWorkDtos;
using TransportMongoDb.Services.HowItWorkServices;

namespace TransportMongoDb.Controllers
{
    public class HowItWorkController : Controller
    {
        private readonly IHowItWorkService _howItWorkService;

        public HowItWorkController(IHowItWorkService howItWorkService)
        {
            _howItWorkService = howItWorkService;
        }

        public async Task<IActionResult> HowItWorkList()
        {
            var value = await _howItWorkService.GetAllHowItWorkAsync();
            return View(value);
        }
        [HttpGet]
        public IActionResult CreateHowItWork()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateHowItWork(CreateHowItWorkDto createHowItWorkDto)
        {
            await _howItWorkService.CreateHowItWorkAsync(createHowItWorkDto);
            return RedirectToAction("HowItWorkServiceList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateHowItWork(string id)
        {
            var value = await _howItWorkService.GetHowItWorkByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateHowItWork(UpdateHowItWorkDto updateHowItWorkDto)
        {
            await _howItWorkService.UpdateHowItWorkAsync(updateHowItWorkDto);
            return RedirectToAction("HowItWorkServiceList");
        }
        public async Task<IActionResult> DeleteHowItWork(string id)
        {
            await _howItWorkService.DeleteHowItWorkAsync(id);
            return RedirectToAction("HowItWorkServiceList");
        }
    }
}
