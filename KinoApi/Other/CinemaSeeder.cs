using KinoApi.Entities;
using System.Collections.Generic;
using System.Linq;

namespace KinoApi.Other
{
    public class CinemaSeeder
    {
        private readonly CinemaDbContext _dbContext;

        public CinemaSeeder(CinemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if(_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Cinema.Any())
                {
                    IEnumerable<Cinema> cinema = GetCinema();
                    _dbContext.Cinema.AddRange(cinema);
                    _dbContext.SaveChanges();
                }
            }
        }
        private IEnumerable<Cinema> GetCinema()
        {
            List<Cinema> cinema = new List<Cinema>()
            {
                new Cinema()
                {
                    Login = "Cierocki",
                    Password = "debil",
                    Email = "Cierocki@debil",
                    Username = "CieroJakub"
                },
                new Cinema()
                {
                    Login = "Cierocki2",
                    Password = "debil2",
                    Email = "Cierocki@debil2",
                    Username = "CieroJakub2"
                }
            };
            return cinema;
        }
    }
}
