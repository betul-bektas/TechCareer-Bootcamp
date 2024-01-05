using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareerBootcampProje.Models{
    public class ClientModel:BaseModel
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        [ForeignKey("Company")]
        public int CompanyId { get; set; }
        public CompanyModel? Company { get; set; }
    }
}