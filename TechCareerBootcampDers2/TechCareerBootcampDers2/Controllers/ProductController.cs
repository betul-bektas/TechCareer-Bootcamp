using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechCareerBootcampDers2.Models;

namespace TechCareerBootcampDers2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public List<Product> products = new List<Product>
        {
            new Product {
                Id = 1,
                Name="Phone",
                UnitPrice=48000,
                Category =new Category {Id=1, Name="Electronic"}},

            new Product {
                Id = 2,
                Name="Missha",
                UnitPrice=100,
                Category= new Category{Id=2, Name="SelfCare"} },

            new Product {
                Id = 3,
                Name="Lenova",
                UnitPrice=30000,
                Category =new Category{Id=1, Name="Electronic"}},

            new Product {
                Id = 4,
                Name="Body Lotion",
                UnitPrice=250,
                Category= new Category{Id=2, Name="SelfCare"} },


        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
                return NotFound();
            else
                return Ok(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
            return StatusCode(200, product);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            if (product == null)
                return BadRequest();
            else
            {
                products.Remove(product);
                return Ok(product);
            }
        }



    }
}
