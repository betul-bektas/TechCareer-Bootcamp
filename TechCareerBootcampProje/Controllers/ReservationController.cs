using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechCareerBootcampProje.Models;

namespace TechCareerBootcampProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController :Controller
    {
        private readonly TechCareerDbContext _context;
        public ReservationController()
        {
            _context =new TechCareerDbContext();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var reservations = _context.Reservations;
            return Ok(reservations);
        }
    }
}