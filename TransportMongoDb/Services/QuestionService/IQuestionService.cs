using TransportMongoDb.Dtos.QuestionDtos;
using TransportMongoDb.Entities;

namespace TransportMongoDb.Services.QuestionService
{
    public interface IQuestionService
    {
        Task<List<ResultQuestionDto>> GetAllQuestionsAsync();

        Task<GetQuestionByIdDto> GetQuestionByIdAsync(string id);

        Task CreateQuestionAsync(CreateQuestionDto createQuestionDto);

        Task UpdateQuestionAsync(UpdateQuestionDto updateQuestionDto);

        Task DeleteQuestionAsync(string id);
    }
}
