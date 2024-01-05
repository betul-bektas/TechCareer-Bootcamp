using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TechCareerBootcampDers3.Models
{
    public class Employee:BaseModel
    {


        [Required(ErrorMessage = "Ad alanı boş geçilemez.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Soyad alanı boş geçilemez.")]
        public string? LastName { get; set; }
        public string? Adress { get; set; }
        
        public string? City { get; set; }

    }
}