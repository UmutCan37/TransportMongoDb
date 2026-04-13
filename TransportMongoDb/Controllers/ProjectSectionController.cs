using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransportMongoDb.Dtos.ProjectSectionDtos;
using TransportMongoDb.Services.ProjectSectionService;

namespace TransportMongoDb.Controllers
{
    public class ProjectSectionController : Controller
    {
        private readonly IProjectSectionService _projectSectionService;

        public ProjectSectionController(IProjectSectionService projectSectionService)
        {
            _projectSectionService = projectSectionService;
        }

        public async Task<IActionResult> ProjectSectionList()
        {
            var value = await _projectSectionService.GetAllProjectSectionAsync();
            return View(value);
        }
        [HttpGet]
        public IActionResult CreateProjectSection()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProjectSection(CreateProjectSectionDto projectSectionCreateDto)
        {
            await _projectSectionService.CreateProjectSectionAsync(projectSectionCreateDto);
            return RedirectToAction("ProjectSectionList");

        }
        [HttpGet]
        public async Task<IActionResult> UpdateProjectSection(string id)
        {
            var value = await _projectSectionService.GetProjectSectionByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateProjectSection(UpdateProjectSectionDto projectSectionUpdateDto)
        {
            await _projectSectionService.UpdateProjectSectionAsync(projectSectionUpdateDto);
            return RedirectToAction("ProjectSectionList");
        }
        public async Task<IActionResult> DeleteProjectSection(string id)
        {
            await _projectSectionService.DeleteProjectSectionAsync(id);
            return RedirectToAction("ProjectSectionList");
        }
    }
}
