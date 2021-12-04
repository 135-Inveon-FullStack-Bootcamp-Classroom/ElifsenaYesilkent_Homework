using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using week_7_FootballManager.Data;
using week_7_FootballManager.Entitites;
using week_7_FootballManager.SeviceAbstracts;

namespace week_7_FootballManager.ServiceImplementations
{
    public class ManagementPositionService : IManagementPositionService
    {
        private readonly ApplicationDbContext _context;
        public ManagementPositionService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ManagementPosition>> GetAllAsync()
        {
            return await _context.ManagementPositions.ToListAsync();
        }
        public async Task<ManagementPosition> GetAsync(int id)
        {
            var managementPosition = await _context.ManagementPositions.FindAsync(id);
            return managementPosition;
        }
        public async Task<ManagementPosition> CreateAsync(ManagementPosition managementPosition)
        {
            _context.ManagementPositions.Add(managementPosition);
            await _context.SaveChangesAsync();
            return managementPosition;
        }
        public async Task DeleteAsync(int id)
        {
            var managementPosition = await _context.ManagementPositions.FindAsync(id);

            if (managementPosition == null)
                throw new Exception("teknik direktör bulunamadı");

            _context.ManagementPositions.Remove(managementPosition);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateAsync(int id, ManagementPosition managementPosition)
        {
            if (id != managementPosition.Id)
            {
                throw new Exception("id yanlış");
            }
            _context.Entry(managementPosition).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManagementPositionExists(id))
                {
                    throw new Exception($"{id}' bulunamadı");
                }
                else
                {
                    throw;
                }
            }

        }

        private bool ManagementPositionExists(int id)
        {
            return _context.ManagementPositions.Any(e => e.Id == id);
        }
    }
}
