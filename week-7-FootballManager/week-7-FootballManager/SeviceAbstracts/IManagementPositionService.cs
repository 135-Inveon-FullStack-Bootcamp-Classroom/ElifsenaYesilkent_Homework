using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using week_7_FootballManager.Entitites;

namespace week_7_FootballManager.SeviceAbstracts
{
    public interface IManagementPositionService
    {
        public Task<IEnumerable<ManagementPosition>> GetAllAsync();
        public Task<ManagementPosition> GetAsync(int id);
        public Task<ManagementPosition> CreateAsync(ManagementPosition managementPosition);
        public Task UpdateAsync(int id, ManagementPosition managementPosition);
        public Task DeleteAsync(int id);

    }
}
