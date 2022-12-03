using KinoApi.DTO;
using KinoApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace KinoApi.Controllers
{
    [Route("api/cinema")]
    [ApiController]
    public class CinemaController : ControllerBase
    {
        private readonly ICinemaService _cinemaService;
  
        public CinemaController(ICinemaService cinemaService)
        {
            _cinemaService = cinemaService;
        }
        [HttpGet("{cinemaId}")]
        public ActionResult<CinemaDto> Get([FromRoute] int cinemaId)
        {
            CinemaDto cinema = _cinemaService.GetCinemaTest(cinemaId);
            return Ok(cinema);
        }

    }
}
