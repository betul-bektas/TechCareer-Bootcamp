using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        [HttpGet]
        public string[] Get()
        {
            string[] country = new string[] { "Türkiye", "Hindistan", "Almanya", "Abd", "Çin","Arjantin","Endonezya","Fransa","Güney Kore","Kuzey Kore", "Güney Afrika","İngiltere","Japonya","Kanada","Rusya","Meksika","Brezilya","Suudi Arabistan" };
            return country;
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            string[] country = new string[] { "Türkiye", "Hindistan", "Almanya", "Abd", "Çin", "Arjantin", "Endonezya", "Fransa", "Güney Kore", "Kuzey Kore", "Güney Afrika", "İngiltere", "Japonya", "Kanada", "Rusya", "Meksika", "Brezilya", "Suudi Arabistan" };
            string indeks = "";

            // Check if the id is valid
            if (id < 0 || id >= country.Length)
            {
                return "Invalid ID";
            }
            else
            {
                for (int i = 0; i < id; i++)
                {
                    indeks += country[i] + "\n";

                }

            }
            return indeks;
        }


    }
}
