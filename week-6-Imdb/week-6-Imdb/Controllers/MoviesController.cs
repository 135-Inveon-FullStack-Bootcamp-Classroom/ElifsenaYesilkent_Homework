using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using week_6_Imdb.Entitites;

namespace week_6_Imdb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public MoviesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            var movies = _dbContext.Movies.ToList();

            return Ok(movies);
        }

        [HttpPost]
        public IActionResult AddMovies([FromBody] Movie movie)
        {
            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();

            return Ok();
        }
        

        [HttpPut]
        public IActionResult UpdateMovies([FromBody] Movie movie)
        {
            _dbContext.Movies.Update(movie);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveMovies([FromBody] Movie movie)
        {
            _dbContext.Movies.Remove(movie);
            _dbContext.SaveChanges();
            return Ok();
        }

    }
}
