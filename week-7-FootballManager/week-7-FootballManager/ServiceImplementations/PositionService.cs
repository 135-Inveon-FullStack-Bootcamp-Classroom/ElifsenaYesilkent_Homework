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
    public class PositionService : IPositionService
    {
        private readonly ApplicationDbContext _context;
        public PositionService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Position>> GetAllAsync()
        {
            return await _context.Positions.ToListAsync();
        }
        public async Task<Position> GetAsync(int id)
        {
            var position = await _context.Positions.FindAsync(id);
            return position;
        }
        public async Task<Position> CreateAsync(Position position)
        {
            _context.Positions.Add(position);
            await _context.SaveChangesAsync();
            return position;
        }
        public async Task DeleteAsync(int id)
        {
            var position = await _context.Positions.FindAsync(id);

            if (position == null)
                throw new Exception("böyle bir mevki yok");

            _context.Positions.Remove(position);
            await _context.SaveChangesAsync();
        }


        public async Task UpdateAsync(int id, Position position)
        {
            if (id != position.Id)
            {
                throw new Exception("id yanlış");
            }
            _context.Entry(position).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PositionExists(id))
                {
                    throw new Exception($"{id}' bulunamadı");
                }
                else
                {
                    throw;
                }
            }

        }

        private bool PositionExists(int id)
        {
            return _context.Positions.Any(e => e.Id == id);
        }
    }
}
