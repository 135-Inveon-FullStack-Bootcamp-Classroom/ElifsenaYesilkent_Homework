using System.Collections.Generic;
using System.Threading.Tasks;
using week_7_FootballManager.Entitites;

namespace week_7_FootballManager.SeviceAbstracts
{
    public interface ITeamService
    {
        public Task<IEnumerable<Team>> GetAllAsync();
        public Task<Team> GetAsync(int id);
        public Task<Team> CreateAsync(Team team);
        public Task UpdateAsync(int id,Team team);
        public Task DeleteAsync(int id);
        public Task<IEnumerable<Team>> GetAllWithFootballersAsync();


    }
}
