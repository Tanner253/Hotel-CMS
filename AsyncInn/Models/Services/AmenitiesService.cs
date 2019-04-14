using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class AmenetiesService : IAmenities
    {
        private AsyncdbContext _context;

        public AmenetiesService(AsyncdbContext context)
        {
            _context = context;
        }
        public bool AmenitiesExists(int id)
        {
            return _context.Amenities.Any(e => e.ID == id);
        }

        public async Task CreateAmenitie(Amenities amenities)
        {
            _context.Add(amenities);
            await _context.SaveChangesAsync();
        }

        public async Task<Amenities> DeleteAmenitie(int id)
        {
            Amenities amenities = await _context.Amenities
                .FirstOrDefaultAsync(m => m.ID == id);
            return amenities;
        }

        public async Task DeleteAmenitieFR(int id)
        {
            var amenities = await _context.Amenities.FindAsync(id);
            _context.Amenities.Remove(amenities);
            await _context.SaveChangesAsync();

        }

        public async Task<Amenities> GetAmenitie(int id)
        {
            try
            {
                var amenities = await _context.Amenities.FindAsync(id);
                if (amenities == null)
                {
                    return null;
                }

                return amenities;
            }
            catch (Exception e)
            {
                
                Console.WriteLine(e);
                return null;
            }

        }

        public async Task<IEnumerable<Amenities>> GetAmenities()
        {
            return await _context.Amenities.ToListAsync();
        }

        public async Task UpdateAmenitie(int id, Amenities amenities)
        {
            _context.Update(amenities);
            await _context.SaveChangesAsync();
        }
    }
}
