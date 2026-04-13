using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransportMongoDb.Services.ProjectSectionService;

namespace TransportMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultWhatWeHaveDoneComponentPartial : ViewComponent
    {
        private readonly IProjectSectionService _projectSectionService;

        public _DefaultWhatWeHaveDoneComponentPartial(IProjectSectionService projectSectionService)
        {
            _projectSectionService = projectSectionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _projectSectionService.GetAllProjectSectionAsync();
            return View(value);
        }
    }
}
