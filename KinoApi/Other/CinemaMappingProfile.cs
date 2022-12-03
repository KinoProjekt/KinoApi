using AutoMapper;
using KinoApi.DTO;
using KinoApi.Entities;

namespace KinoApi.Other
{
    public class CinemaMappingProfile : Profile
    {
        public CinemaMappingProfile()
        {
            CreateMap<Cinema, CinemaDto>();
        }
        
    }
}
