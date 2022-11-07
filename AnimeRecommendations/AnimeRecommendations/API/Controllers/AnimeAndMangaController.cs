
using AnimeRecommendations.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace AnimeRecommendations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeAndMangaController : ControllerBase
    {
        // GET: api/AnimeAndManga
        [HttpGet(Name = "GetAnimeManga")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AnimeAndManga/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        //Validation 
        private bool ValidateEntry(AnimeManga animeManga)
        {
            //required validation
            if (animeManga.IsManga.HasValue == false)
            {
                return false;
                
            }
            
            if (string.IsNullOrWhiteSpace(animeManga.Title))
            {
                return false;
            }
            
            if (animeManga.IsHardcopy == false &&string.IsNullOrWhiteSpace( animeManga.Uri))
            { return false;}
            
            
            return true;
            //optional 
        }
        //Compare Value

        // POST: api/AnimeAndManga
        [HttpPost(Name = "CreateAnimeManga")]
        public ActionResult Create([FromBody] AnimeManga animeManga)
        {
            //if incoming data is not valid 
            //return Bad Request
            
            if (ValidateEntry(animeManga) == false) 
            {
                return BadRequest();
            }
            
            //call service to create new item 
            //if service returns error
            //return error 
            return Ok();
        }

        // PUT: api/AnimeAndManga/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/AnimeAndManga/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
