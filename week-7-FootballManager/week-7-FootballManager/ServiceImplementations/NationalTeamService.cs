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
    public class NationalTeamService : INationalTeamService
    {
        private readonly ApplicationDbContext _context;
        public NationalTeamService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<NationalTeam>> GetAllAsync()
        {
            return await _context.NationalTeams.ToListAsync();
        }
        public async Task<NationalTeam> GetAsync(int id)
        {
            var nationalTeam = await _context.NationalTeams.FindAsync(id);
            return nationalTeam;
        }
        public async Task<NationalTeam> CreateAsync(NationalTeam nationalTeam)
        {
            _context.NationalTeams.Add(nationalTeam);
            await _context.SaveChangesAsync();
            return nationalTeam;
        }
        public async Task DeleteAsync(int id)
        {
            var coach = await _context.NationalTeams.FindAsync(id);

            if (coach == null)
                throw new Exception("teknik direktör bulunamadı");

            _context.NationalTeams.Remove(coach);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateAsync(int id, NationalTeam nationalTeam)
        {
            if (id != nationalTeam.Id)
            {
                throw new Exception("id yanlış");
            }
            _context.Entry(nationalTeam).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NationalTeamExists(id))
                {
                    throw new Exception($"{id}' bulunamadı");
                }
                else
                {
                    throw;
                }
            }

        }

        private bool NationalTeamExists(int id)
        {
            return _context.Coaches.Any(e => e.Id == id);
        }
    }
}
