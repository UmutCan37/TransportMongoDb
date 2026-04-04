using AutoMapper;
using MongoDB.Driver;
using TransportMongoDb.Dtos.OfferDtos;
using TransportMongoDb.Entities;
using TransportMongoDb.Settings;

namespace TransportMongoDb.Services.OfferService
{
    public class OfferService : IOfferService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Offer> _offerCollection;
        public OfferService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _offerCollection = database.GetCollection<Offer>(_databaseSettings.OfferCollectionName);
            _mapper = mapper;
        }
        public async Task CreateOfferAsync(CreateOfferDto createOfferDto)
        {
            var value = _mapper.Map<Offer>(createOfferDto);
            await _offerCollection.InsertOneAsync(value);
        }

        public async Task DeleteOfferAsync(string id)
        {
            await _offerCollection.DeleteOneAsync(x => x.OfferId == id);
        }

        public async Task<List<ResultOfferDto>> GetAllOfferAsync()
        {
            var value = await _offerCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultOfferDto>>(value);
        }

        public async Task<GetOfferByIdDto> GetOfferByIdAsync(string id)
        {
            var value =await _offerCollection.Find(x => x.OfferId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetOfferByIdDto>(value);
        }

        public Task UpdateOfferAsync(UpdateOfferDto updateOfferDto)
        {
            var value = _mapper.Map<Offer>(updateOfferDto);
            return _offerCollection.FindOneAndReplaceAsync(x => x.OfferId == updateOfferDto.OfferId, value);
        }
    }
}
