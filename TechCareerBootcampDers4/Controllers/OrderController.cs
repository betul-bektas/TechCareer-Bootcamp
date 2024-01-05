using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechCareerBootcampDers4.Models;

namespace TechCareerBootcampDers4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly TechCareerDbContext _context;
        public OrderController()
        {
            _context = new TechCareerDbContext();
        }
        [HttpGet]
        public IActionResult Get()
        {
            //var orders =_context.Orders.Include(x=> x.OrderNumber).ToList();
            //return Ok(orders);
            return Ok();
        }
        
        public IActionResult Index()
        {
            return View();
        }

    }
}