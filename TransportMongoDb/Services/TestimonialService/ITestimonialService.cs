using TransportMongoDb.Dtos.TestimonialDtos;

namespace TransportMongoDb.Services.TestimonialService
{
    public interface ITestimonialService
    {
        Task CreateTestimonialAsync(CreateTestimonialDto createTestimonialDto);
        Task<List<ResultTestimonialDto>> GetAllTestimonialsAsync();
        Task<GetTestimonialByIdDto> GetTestimonialByIdAsync(string testimonialId);
        Task UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto);
        Task DeleteTestimonialAsync(string testimonialId);
    }
}
