using AutoMapper;
using TransportMongoDb.Entities;
using TransportMongoDb.Dtos.SliderDtos;
using TransportMongoDb.Dtos.BrandDtos;
using TransportMongoDb.Dtos.OfferDtos;
using TransportMongoDb.Dtos.AboutDtos;
using TransportMongoDb.Dtos.GetInTouchDtos;

namespace TransportMongoDb.Mapping
{
    public class GeneralMapping:Profile

    {
        public GeneralMapping()
        {
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
            CreateMap<Slider, GetSliderByIdDto>().ReverseMap();

            CreateMap<Brand, ResultBrandDto>().ReverseMap();
            CreateMap<Brand, CreateBrandDto>().ReverseMap();
            CreateMap<Brand, UpdateBrandDto>().ReverseMap();
            CreateMap<Brand, GetBrandByIdDto>().ReverseMap();

            CreateMap<Offer, ResultOfferDto>().ReverseMap();
            CreateMap<Offer, CreateOfferDto>().ReverseMap();
            CreateMap<Offer, UpdateOfferDto>().ReverseMap();
            CreateMap<Offer, GetOfferByIdDto>().ReverseMap();

            CreateMap<About,ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutByIdDto>().ReverseMap();

            CreateMap<GetInTouch,ResultGetInTouchDto>().ReverseMap();
            CreateMap<GetInTouch, CreateGetInTouchDto>().ReverseMap();
            CreateMap<GetInTouch, UpdateGetInTouchDto>().ReverseMap();
            CreateMap<GetInTouch,GetGetInTouchByIdDto>().ReverseMap();
        }
    }
}
