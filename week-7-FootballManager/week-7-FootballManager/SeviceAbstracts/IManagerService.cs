using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using week_7_FootballManager.Entitites;

namespace week_7_FootballManager.SeviceAbstracts
{
    public interface IManagerService
    {
        public Task<IEnumerable<Manager>> GetAllAsync();
        public Task<Manager> GetAsync(int id);
        public Task<Manager> CreateAsync(Manager manager);
        public Task UpdateAsync(int id, Manager manager);
        public Task DeleteAsync(int id);

    }
}
