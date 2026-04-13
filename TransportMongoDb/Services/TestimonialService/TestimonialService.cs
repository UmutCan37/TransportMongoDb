using AutoMapper;
using MongoDB.Driver;
using TransportMongoDb.Dtos.TestimonialDtos;
using TransportMongoDb.Entities;
using TransportMongoDb.Settings;

namespace TransportMongoDb.Services.TestimonialService
{
    public class TestimonialService : ITestimonialService
    {
        private readonly IMongoCollection<Testimonial> _testimonialCollection;
        private readonly IMapper _mapper;

        public TestimonialService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _testimonialCollection = database.GetCollection<Testimonial>(_databaseSettings.TestimonialCollectionName);
            _mapper = mapper;
        }
        public async Task CreateTestimonialAsync(CreateTestimonialDto createTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(createTestimonialDto);
            await _testimonialCollection.InsertOneAsync(value);
        }

        public async Task DeleteTestimonialAsync(string testimonialId)
        {
            await _testimonialCollection.DeleteOneAsync(x => x.TestimonialId == testimonialId);
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonialsAsync()
        {
            var values = await _testimonialCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultTestimonialDto>>(values);
        }

        public async Task<GetTestimonialByIdDto> GetTestimonialByIdAsync(string testimonialId)
        {
            var value= await _testimonialCollection.Find(x => x.TestimonialId == testimonialId).FirstOrDefaultAsync();
            return _mapper.Map<GetTestimonialByIdDto>(value);
        }

        public Task UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(updateTestimonialDto);
            return _testimonialCollection.FindOneAndReplaceAsync(x => x.TestimonialId == updateTestimonialDto.TestimonialId, value);
        }
    }
}
