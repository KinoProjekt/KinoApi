using AutoMapper;
using KinoApi.DTO;
using KinoApi.Entities;
using System;
using System.Linq;

namespace KinoApi.Services
{
    public interface ICinemaService
    {
        CinemaDto GetCinemaTest(int id);
    }
    public class CinemaService : ICinemaService
    {
        private readonly CinemaDbContext _context;
        private readonly IMapper _mapper;

        public CinemaService(CinemaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public CinemaDto GetCinemaTest(int id)
        {
            Cinema cinema = _context.Cinema.FirstOrDefault(x => x.Id == id);
            if(cinema is null)
            {
                throw new Exception("Jebać Cierockiego");
            }
            CinemaDto cinemaDto = _mapper.Map<CinemaDto>(cinema);
            return cinemaDto;
        }
    }
}
