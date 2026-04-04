using AutoMapper;
using MongoDB.Driver;
using TransportMongoDb.Dtos.BrandDtos;
using TransportMongoDb.Entities;
using TransportMongoDb.Settings;

namespace TransportMongoDb.Services.BrandService
{
    public class BrandService : IBrandService
    {
        private readonly IMongoCollection<Brand> _brandCollection;
        private readonly IMapper _mapper;

        public BrandService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _brandCollection = database.GetCollection<Brand>(_databaseSettings.BrandCollectionName);
            _mapper = mapper;
        }
        public async Task CreateBrandAsync(CreateBrandDto createBrandDto)
        {
            var value=_mapper.Map<Brand>(createBrandDto);
            await _brandCollection.InsertOneAsync(value);
        }

        public async Task DeleteBrandAsync(string id)
        {
            await _brandCollection.DeleteOneAsync(x => x.BrandId == id);
        }

        public async Task<List<ResultBrandDto>> GetAllBrandAsync()
        {
            var value=await _brandCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultBrandDto>>(value);
        }

        public async Task<GetBrandByIdDto> GetBrandByIdAsync(string id)
        {
            var valeu=await _brandCollection.Find(x => x.BrandId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetBrandByIdDto>(valeu);
        }

        public Task UpdateBrandAsync(UpdateBrandDto updateBrandDto)
        {
            var value = _mapper.Map<Brand>(updateBrandDto);
            return _brandCollection.FindOneAndReplaceAsync(x => x.BrandId == updateBrandDto.BrandId, value);
        }
    }
}
