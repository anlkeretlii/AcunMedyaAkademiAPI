using AutoMapper;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProjectEntityLayer.Concrete;
using HotelProjectWebUI.Dtos.AboutDto;
using HotelProjectWebUI.Dtos.TestimonialDto;
using HotelProjectWebUI.Dtos.AppUserDto;
using HotelProjectWebUI.Dtos.ServiceDto;
using HotelProjectWebUI.Dtos.BookingDto;
using HotelProjectWebUI.Dtos.LoginDto;
using HotelProjectWebUI.Dtos.RegisterDto;
using HotelProjectWebUI.Dtos.StaffDto;
using HotelProjectWebUI.Dtos.SubscribeDto;


namespace HotelProjectWebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateNewUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

            CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();

            CreateMap<ResultStaffDto, Staff>().ReverseMap();

            CreateMap<CreateSubscribeDto, Subscribe>().ReverseMap();

            CreateMap<CreateBookingDto, Booking>().ReverseMap();
            CreateMap<ApprovedReservationDto, Booking>().ReverseMap();

            CreateMap<CreateGuestDto, Guest>().ReverseMap();
            CreateMap<UpdateGuestDto, Guest>().ReverseMap();

            CreateMap<ResultAppUserDto, AppUser>().ReverseMap();

        }
    }
}