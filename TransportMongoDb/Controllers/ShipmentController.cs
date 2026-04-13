using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransportMongoDb.Dtos.ShipmentDtos;
using TransportMongoDb.Services.ShipmentServices;

namespace TransportMongoDb.Controllers
{
    public class ShipmentController : Controller
    {
        private readonly IShipmentService _shipmentService;

        public ShipmentController(IShipmentService shipmentService)
        {
            _shipmentService = shipmentService;
        }

        public async Task<IActionResult> ShipmentList()
        {
            var value = await _shipmentService.GetAllShipmentAsync();
            return View(value);
        }
        [HttpGet]
        public IActionResult CreateShipment()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateShipment(CreateShipmentDto createShipmentDto)
        {
            await _shipmentService.CreateShipmentAsync(createShipmentDto);
            return RedirectToAction("ShipmentList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateShipment(string id)
        {
            var value = await _shipmentService.GetShipmentByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateShipment(UpdateShipmentDto updateShipmentDto)
        {
            await _shipmentService.UpdateShipmentAsync(updateShipmentDto);
            return RedirectToAction("ShipmentList");
        }
        public async Task<IActionResult> DeleteShipment(string id)
        {
            await _shipmentService.DeleteShipmentAsync(id);
            return RedirectToAction("ShipmentList");
        }
    }
}

