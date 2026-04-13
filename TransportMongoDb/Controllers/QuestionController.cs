using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TransportMongoDb.Dtos.QuestionDtos;
using TransportMongoDb.Services.QuestionService;

namespace TransportMongoDb.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        public async Task<IActionResult> QuestionList()
        {
            var value = await _questionService.GetAllQuestionsAsync();
            return View(value);
        }
        [HttpGet]
        public IActionResult CreateQuestion()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateQuestion(CreateQuestionDto createQuestionDto)
        {
            await _questionService.CreateQuestionAsync(createQuestionDto);
            return RedirectToAction("QuestionList");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateQuestion(string id)
        {
            var value = await _questionService.GetQuestionByIdAsync(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateQuestion(UpdateQuestionDto updateQuestionDto)
        {
            await _questionService.UpdateQuestionAsync(updateQuestionDto);
            return RedirectToAction("QuestionList");
        }
        public async Task<IActionResult> DeleteQuestion(string id)
        {
            await _questionService.DeleteQuestionAsync(id);
            return RedirectToAction("QuestionList");
        }
    }
}
