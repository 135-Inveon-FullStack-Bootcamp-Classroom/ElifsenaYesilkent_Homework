using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
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
            var actor = _dbContext.Actors.ToList();

            return Ok(actor);
        }

        [HttpGet("{id}")]
        public IActionResult GetActor(int id)
        {
            var actor = _dbContext.Actors.FindAsync(id);

            return Ok(actor);
        }

        [HttpPost]
        public async Task<ActionResult<Actor>> PostActor(Actor actor)
        {
            _dbContext.Actors.Add(actor);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction("GetActor", new { id = actor.Id }, actor);
        }


        [HttpPut]
        public IActionResult UpdateActor([FromBody] Actor actor)
        {
            _dbContext.Actors.Update(actor);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveActor([FromBody] Actor actor)
        {
            _dbContext.Actors.Remove(actor);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
