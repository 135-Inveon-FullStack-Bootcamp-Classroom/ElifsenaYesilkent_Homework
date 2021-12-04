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
    public class TacticService : ITacticService
    {
        private readonly ApplicationDbContext _context;
        public TacticService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Tactic>> GetAllAsync()
        {
            return await _context.Tactics.ToListAsync();
        }
        public async Task<Tactic> GetAsync(int id)
        {
            var tactic = await _context.Tactics.FindAsync(id);
            return tactic;
        }
        public async Task<Tactic> CreateAsync(Tactic tactic)
        {
            _context.Tactics.Add(tactic);
            await _context.SaveChangesAsync();
            return tactic;
        }
        public async Task DeleteAsync(int id)
        {
            var tactic = await _context.Tactics.FindAsync(id);

            if (tactic == null)
                throw new Exception("taktik bulunamadı");

            _context.Tactics.Remove(tactic);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateAsync(int id, Tactic tactic)
        {
            if (id != tactic.Id)
            {
                throw new Exception("id yanlış");
            }
            _context.Entry(tactic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TacticExists(id))
                {
                    throw new Exception($"{id}' bulunamadı");
                }
                else
                {
                    throw;
                }
            }

        }

        private bool TacticExists(int id)
        {
            return _context.Tactics.Any(e => e.Id == id);
        }
    }
}
