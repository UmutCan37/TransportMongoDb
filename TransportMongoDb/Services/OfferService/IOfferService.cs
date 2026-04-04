using TransportMongoDb.Dtos.OfferDtos;

namespace TransportMongoDb.Services.OfferService
{
    public interface IOfferService
    {
        Task<List<ResultOfferDto>> GetAllOfferAsync();

        Task CreateOfferAsync(CreateOfferDto createOfferDto);

        Task UpdateOfferAsync(UpdateOfferDto updateOfferDto);

        Task DeleteOfferAsync(string id);

        Task<GetOfferByIdDto> GetOfferByIdAsync(string id);


    }
}
