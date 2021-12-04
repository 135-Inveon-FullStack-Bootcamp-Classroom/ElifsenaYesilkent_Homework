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
    public class ManagerService : IManagerService
    {
        private readonly ApplicationDbContext _context;
        public ManagerService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Manager>> GetAllAsync()
        {
            return await _context.Managers.ToListAsync();
        }
        public async Task<Manager> GetAsync(int id)
        {
            var manager = await _context.Managers.FindAsync(id);
            return manager;
        }
        public async Task<Manager> CreateAsync(Manager manager)
        {
            _context.Managers.Add(manager);
            await _context.SaveChangesAsync();
            return manager;
        }
        public async Task DeleteAsync(int id)
        {
            var manager = await _context.Managers.FindAsync(id);

            if (manager == null)
                throw new Exception("teknik direktör bulunamadı");

            _context.Managers.Remove(manager);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateAsync(int id, Manager manager)
        {
            if (id != manager.Id)
            {
                throw new Exception("id yanlış");
            }
            _context.Entry(manager).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManagerExists(id))
                {
                    throw new Exception($"{id}' bulunamadı");
                }
                else
                {
                    throw;
                }
            }

        }

        private bool ManagerExists(int id)
        {
            return _context.Managers.Any(e => e.Id == id);
        }
    }
}
