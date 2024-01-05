using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechCareerBootcampDers3.Models;

namespace TechCareerBootcampDers4.Models
{
    public class Order:BaseModel
    {
        public int OrderNumber { get; set; }
        public int TotalPrice { get; set; }
        public List<WebUser> WebUsers { get; set; }

        



    }
}