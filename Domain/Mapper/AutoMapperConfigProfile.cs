
using AutoMapper;
using Domain.Authentication;
using Domain.DTO;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mapper
{
    public class AutoMapperConfigProfile : Profile
    {
        public AutoMapperConfigProfile()
        {
            CreateMap<Booking, GetBookingDTO>();
            CreateMap<UserRegisterRequest,RegisterRequestDto > ();
            CreateMap<GetDoctorsDto,Doctor>();
        }
    }
}
