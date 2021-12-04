using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using week_7_FootballManager.Data;
using week_7_FootballManager.Entitites;
using week_7_FootballManager.ServiceImplementations;
using week_7_FootballManager.SeviceAbstracts;
using week_7_FootballManager.UnitOfWork;

namespace week_7_FootballManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public TeamsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Team>> GetTeamId(int id)
        {
            var team = await _unitOfWork.TeamService.GetAsync(id);
            return Ok(team);
        }

        [HttpGet]
        public async Task<ActionResult<Team>> GetTeam()
        {
            var teams = await _unitOfWork.TeamService.GetAllAsync();
            //var team = await _unitOfWork.TeamService.GetAllWithFootballersAsync();

            return Ok(teams);
        }



        [HttpPost]
        public async Task<ActionResult<Team>> PostTeam([FromBody] Team team)
        {
            var crtteam = await _unitOfWork.TeamService.CreateAsync(team);
            return Ok(crtteam);
        }
        //example
        [HttpPost("{id}/add-footballer")]
        public async Task<IActionResult> AddFootballer(int id, [FromBody] Footballer footballer)
        {
            footballer.Team = await _unitOfWork.TeamService.GetAsync(id);
            var createFootballer = await _unitOfWork.FootballerService.CreateAsync(footballer);

            return Ok(createFootballer);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTeam(int id)
        {
            await _unitOfWork.TeamService.DeleteAsync(id);
            return NoContent();
        }

        
    }

}
