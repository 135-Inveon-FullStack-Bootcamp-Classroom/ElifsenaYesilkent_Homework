using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using week_7_FootballManager.Entitites;

namespace week_7_FootballManager.SeviceAbstracts
{
    public interface INationalTeamService
    {
        public Task<IEnumerable<NationalTeam>> GetAllAsync();
        public Task<NationalTeam> GetAsync(int id);
        public Task<NationalTeam> CreateAsync(NationalTeam nationalTeam);
        public Task UpdateAsync(int id, NationalTeam nationalTeam);
        public Task DeleteAsync(int id);

    }
}
