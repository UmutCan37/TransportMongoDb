using AutoMapper;
using TransportMongoDb.Entities;
using TransportMongoDb.Dtos.SliderDtos;
using TransportMongoDb.Dtos.BrandDtos;
using TransportMongoDb.Dtos.OfferDtos;
using TransportMongoDb.Dtos.AboutDtos;
using TransportMongoDb.Dtos.GetInTouchDtos;
using TransportMongoDb.Dtos.HowItWorkDtos;
using TransportMongoDb.Dtos.TestimonialDtos;
using TransportMongoDb.Dtos.ProjectSectionDtos;
using TransportMongoDb.Dtos.QuestionDtos;
using TransportMongoDb.Dtos.ShipmentDtos;
using TransportMongoDb.Dtos.ShipmentTrackingDtos;

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

            CreateMap<HowItWork,ResultHowItWorkDto>().ReverseMap();
            CreateMap<HowItWork, CreateHowItWorkDto>().ReverseMap();
            CreateMap<HowItWork, UpdateHowItWorkDto>().ReverseMap();
            CreateMap<HowItWork, GetHowItWorkByIdDto>().ReverseMap();

            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialByIdDto>().ReverseMap();

            CreateMap<ProjectSection, ResultProjectSectionDto>().ReverseMap();
            CreateMap<ProjectSection, CreateProjectSectionDto>().ReverseMap();
            CreateMap<ProjectSection, UpdateProjectSectionDto>().ReverseMap();
            CreateMap<ProjectSection, GetProjectSectionByIdDto>().ReverseMap();

            CreateMap<Question, ResultQuestionDto>().ReverseMap();
            CreateMap<Question, CreateQuestionDto>().ReverseMap();
            CreateMap<Question, UpdateQuestionDto>().ReverseMap();
            CreateMap<Question, GetQuestionByIdDto>().ReverseMap();

            CreateMap<Shipment, ResultShipmentDto>().ReverseMap();
            CreateMap<Shipment, CreateShipmentDto>().ReverseMap();
            CreateMap<Shipment, UpdateShipmentDto>().ReverseMap();
            CreateMap<Shipment, GetShipmentByIdDto>().ReverseMap();

            CreateMap<ShipmentTracking, ResultShipmentTrackingDto>().ReverseMap();
            CreateMap<ShipmentTracking, CreateShipmentTrackingDto>().ReverseMap();
            CreateMap<ShipmentTracking, UpdateShipmentTrackingDto>().ReverseMap();
            

        }
    }
}
