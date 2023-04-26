using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul9_1302213026.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        public static List<Movie> listMov = new List<Movie>() { 
        
            new Movie(){Title = "The Shawshank Redemption",Director = " Frank Darabont",Stars = { "Tim Robbins", " Morgan Freeman"," Bob Gunton", "William Sadler" },Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion." },
            new Movie(){Title = "The Godfather",Director = "Francis Ford Coppola",Stars= {"Marlon Brando"," Al Pacino", "James Caan", "Diane Keaton"},Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."},
            new Movie(){Title = " The Dark Knight",Director = "Christopher Nolan",Stars = { " Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"}, Description="When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."}
        };
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return listMov;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return listMov[id];
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            listMov.Add(value);
        }

        // PUT api/<ValuesController>/5
        /*[HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }*/

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMov.RemoveAt(id);
        }
    }
}
