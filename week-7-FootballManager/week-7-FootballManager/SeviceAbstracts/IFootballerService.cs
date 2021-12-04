using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using week_7_FootballManager.Entitites;

namespace week_7_FootballManager.SeviceAbstracts
{
    public interface IFootballerService
    {
        public Task<IEnumerable<Footballer>> GetAllAsync();
        public Task<Footballer> GetAsync(int id);
        public Task<Footballer> CreateAsync(Footballer footballer);
        public Task UpdateAsync(int id, Footballer footballer);
        public Task DeleteAsync(int id);

    }
}
