using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using week_7_FootballManager.Entitites;

namespace week_7_FootballManager.SeviceAbstracts
{
    public interface IPositionService
    {
        public Task<IEnumerable<Position>> GetAllAsync();
        public Task<Position> GetAsync(int id);
        public Task<Position> CreateAsync(Position position);
        public Task UpdateAsync(int id, Position position);
        public Task DeleteAsync(int id);

    }
}
