using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransportMongoDb.Services.QuestionService;

namespace TransportMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultFrequentlyAskedQuestionsComponentPartial : ViewComponent
    {
        private readonly IQuestionService _questionService;

        public _DefaultFrequentlyAskedQuestionsComponentPartial(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _questionService.GetAllQuestionsAsync();
            return View(value);
        }
    }
}
