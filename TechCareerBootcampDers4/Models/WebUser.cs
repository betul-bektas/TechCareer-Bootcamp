using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using TechCareerBootcampDers3.Models;

namespace TechCareerBootcampDers4.Models
{
    public class WebUser:BaseModel
    {
        public string? Email { get; set; }
        public string? Adress { get; set; }
        public string? Phone { get; set; }
        public List<Order> Orders { get; set; }

    }
}