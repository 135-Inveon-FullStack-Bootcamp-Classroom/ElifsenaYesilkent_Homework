using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using week_6_Imdb.Entitites;

namespace week_6_Imdb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AwardsController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;

        public AwardsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAward()
        {
            var award = _dbContext.Award.ToList();

            return Ok(award);
        }

        [HttpPost]
        public IActionResult AddAward([FromBody] Award award)
        {
            _dbContext.Award.Add(award);
            _dbContext.SaveChanges();
            return Ok();
        }


        [HttpPut]
        public IActionResult UpdateAward([FromBody] Award award)
        {
            _dbContext.Award.Update(award);
            _dbContext.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IActionResult RemoveAward([FromBody] Award award)
        {
            _dbContext.Award.Remove(award);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
