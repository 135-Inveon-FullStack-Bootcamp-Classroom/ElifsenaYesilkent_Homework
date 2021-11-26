using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using week_6_Imdb.Entitites;

namespace week_6_Imdb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public NewsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetNews()
        {
            var news = _dbContext.Actor.ToList();

            return Ok(news);
        }

        [HttpPost]
        public IActionResult AddNews([FromBody] News news)
        {
            _dbContext.News.Add(news);
            _dbContext.SaveChanges();
            return Ok();
        }


        [HttpPut]
        public IActionResult UpdateNews([FromBody] News news)
        {
            _dbContext.News.Update(news);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveNews([FromBody] News news)
        {
            _dbContext.News.Remove(news);
            _dbContext.SaveChanges();
            return Ok();
        }

    }
}
