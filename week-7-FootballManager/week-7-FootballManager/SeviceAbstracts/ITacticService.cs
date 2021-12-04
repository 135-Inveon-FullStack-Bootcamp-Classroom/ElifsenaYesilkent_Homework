using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using week_7_FootballManager.Entitites;

namespace week_7_FootballManager.SeviceAbstracts
{
    public interface ITacticService
    {
        public Task<IEnumerable<Tactic>> GetAllAsync();
        public Task<Tactic> GetAsync(int id);
        public Task<Tactic> CreateAsync(Tactic tactic);
        public Task UpdateAsync(int id, Tactic tactic);
        public Task DeleteAsync(int id);

    }
}
