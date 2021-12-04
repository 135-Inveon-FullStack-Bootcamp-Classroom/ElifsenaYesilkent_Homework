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
    public class CoachService : ICoachService
    {
        private readonly ApplicationDbContext _context;
        public CoachService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Coach>> GetAllAsync()
        {
            return await _context.Coaches.ToListAsync();
        }
        public async Task<Coach> GetAsync(int id)
        {
            var coach = await _context.Coaches.FindAsync(id);
            return coach;
        }
        public async Task<Coach> CreateAsync(Coach coach)
        {
            _context.Coaches.Add(coach);
            await _context.SaveChangesAsync();
            return coach;
        }
        public async Task DeleteAsync(int id)
        {
            var coach = await _context.Coaches.FindAsync(id);

            if (coach == null)
                throw new Exception("teknik direktör bulunamadı");

            _context.Coaches.Remove(coach);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateAsync(int id, Coach coach)
        {
            if (id != coach.Id)
            {
                throw new Exception("id yanlış");
            }
            _context.Entry(coach).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CoachExists(id))
                {
                    throw new Exception($"{id}' bulunamadı");
                }
                else
                {
                    throw;
                }
            }

        }

        private bool CoachExists(int id)
        {
            return _context.Coaches.Any(e => e.Id == id);
        }
    }
}
