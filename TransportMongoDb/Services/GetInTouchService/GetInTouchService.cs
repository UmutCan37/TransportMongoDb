using AutoMapper;
using MongoDB.Driver;
using TransportMongoDb.Dtos.GetInTouchDtos;
using TransportMongoDb.Entities;
using TransportMongoDb.Settings;

namespace TransportMongoDb.Services.GetInTouchService
{
    public class GetInTouchService : IGetInTouchService
    {
        private readonly IMongoCollection<GetInTouch> _getintouchCollection;
        private readonly IMapper _mapper;

        public GetInTouchService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _getintouchCollection = database.GetCollection<GetInTouch>(_databaseSettings.GetInTouchCollectionName);
            _mapper = mapper;
        }
        public async Task CreateGetInTouchAsync(CreateGetInTouchDto createGetInTouchDto)
        {
            var value = _mapper.Map<GetInTouch>(createGetInTouchDto);
            await _getintouchCollection.InsertOneAsync(value);
        }

        public async Task DeleteGetInTouchAsync(string id)
        {
            await _getintouchCollection.DeleteOneAsync(x => x.GetInTouchId == id);
        }

        public async Task<List<ResultGetInTouchDto>> GetAllGetInTouchAsync()
        {
            var value = await _getintouchCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultGetInTouchDto>>(value);
        }

        public async Task<GetGetInTouchByIdDto> GetGetInTouchByIdAsync(string id)
        {
            var value = await _getintouchCollection.Find(x => x.GetInTouchId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetGetInTouchByIdDto>(value);
        }

        public Task UpdateGetInTouchAsync(UpdateGetInTouchDto updateGetInTouchDto)
        {
            var value = _mapper.Map<GetInTouch>(updateGetInTouchDto);
            return _getintouchCollection.FindOneAndReplaceAsync(x => x.GetInTouchId == updateGetInTouchDto.GetInTouchId, value);
        }
    }
}
