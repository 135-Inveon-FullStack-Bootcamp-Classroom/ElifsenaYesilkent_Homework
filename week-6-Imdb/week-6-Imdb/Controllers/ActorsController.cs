using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using week_6_Imdb.Entitites;

namespace week_6_Imdb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public ActorsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetActor()
        {
            var actor = _dbContext.Actor.ToList();

            return Ok(actor);
        }

        [HttpPost]
        public IActionResult AddActor([FromBody] Actor actor)
        {
            _dbContext.Actor.Add(actor);
            _dbContext.SaveChanges();
            return Ok();
        }


        [HttpPut]
        public IActionResult UpdateActor([FromBody] Actor actor)
        {
            _dbContext.Actor.Update(actor);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveActor([FromBody] Actor actor)
        {
            _dbContext.Actor.Remove(actor);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
