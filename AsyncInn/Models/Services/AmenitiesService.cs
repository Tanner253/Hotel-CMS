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
        /// <summary>
        /// creates amenity
        /// </summary>
        /// <param name="amenities">passes in amenity object ready for user input</param>
        /// <returns>amenity added to database</returns>
        public async Task CreateAmenitie(Amenities amenities)
        {
            try
            {
                _context.Add(amenities);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// locates the amenity to delte
        /// </summary>
        /// <param name="id">the amenity reference</param>
        /// <returns>the amenity to delete</returns>
        public async Task<Amenities> DeleteAmenitie(int id)
        {
            try
            {

            Amenities amenities = await _context.Amenities
                .FirstOrDefaultAsync(m => m.ID == id);
            return amenities;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return null;
            }
        }
        /// <summary>
        /// will delete a selected amenity
        /// </summary>
        /// <param name="id">the id of selected amenity</param>
        /// <returns>the task to controller</returns>
        public async Task DeleteAmenitieFR(int id)
        {
            try
            {
                var amenities = await _context.Amenities.FindAsync(id);
                _context.Amenities.Remove(amenities);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                
            }

        }
        /// <summary>
        /// gets amenities
        /// </summary>
        /// <param name="id">the id of the amenity</param>
        /// <returns>amenitie</returns>
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
        /// <summary>
        /// gets all amenities
        /// </summary>
        /// <returns>will return a collection of amenitities</returns>
        public async Task<IEnumerable<Amenities>> GetAmenities()
        {
            try
            {

            return await _context.Amenities.ToListAsync();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return null;
            }
        }
        /// <summary>
        /// will update a selected amenity
        /// </summary>
        /// <param name="id">selected amenity</param>
        /// <param name="amenities">the amenity object</param>
        /// <returns>the task to controller</returns>
        public async Task UpdateAmenitie(int id, Amenities amenities)
        {
            try
            {
            _context.Update(amenities);
            await _context.SaveChangesAsync();

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }
    }
}
