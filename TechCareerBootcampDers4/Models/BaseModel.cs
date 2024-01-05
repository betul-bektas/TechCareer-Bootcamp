using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechCareerBootcampDers3.Models
{
    public class BaseModel 
    {

        public int Id { get; set; }
        public DateTime? Birtdate { get; set; }
        public DateTime? AddDate { get; set; }


    }
}