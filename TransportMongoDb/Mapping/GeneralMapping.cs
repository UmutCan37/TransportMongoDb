using AutoMapper;
using TransportMongoDb.Entities;
using TransportMongoDb.Dtos.SliderDtos;

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
        }
    }
}
