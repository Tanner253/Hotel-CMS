using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class HotelService : IHotelManager
    {
        private AsyncdbContext _context;

        public HotelService(AsyncdbContext context)
        {
            _context = context;
        }

        public async Task CreateHotel(Hotel hotel)
        {
            _context.Add(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task<Hotel> DeleteHotel(int id)
        {

            Hotel hotel = await _context.Hotel
                .FirstOrDefaultAsync(m => m.ID == id);
            return hotel;


        }
        public async Task DeleteHotelFR(int id)
        {
            var hotel = await _context.Hotel.FindAsync(id);
            _context.Hotel.Remove(hotel);
            await _context.SaveChangesAsync();

        }
        /*         public async Task<Student> GetStudent(int id)
        {
            Student student = await _context.Students
                                            .Include(t => t.Transcripts)
                                            .ThenInclude(x => x.Course)
                                            .Include(t => t.Enrollments)
                                            .FirstOrDefaultAsync(m => m.ID == id);

            return student;

        }*/

        public async Task<Hotel> GetHotel(int id)
        {
            var course = await _context.Hotel.FindAsync(id);


            return course;
        }

        public async Task<IEnumerable<Hotel>> GetHotels()
        {
            var hotels = await _context.Hotel.ToListAsync();
            return hotels;
        }

        public bool HotelExists(int id)
        {
            return _context.Hotel.Any(e => e.ID == id);

        }

        public async Task<IEnumerable<HotelRoom>> GetHotelRooms(int hotelId)
        {

            var hotelrooms = await  _context.HotelRoom
                                           .Include(t => t.Hotel)
                                            .Where(m => m.HotelID == hotelId).ToListAsync();
            /* var allHotelRooms = from rm in _context.HotelRoom
                                 where rm.HotelID == id
                                 select rm;
                                 */

            return hotelrooms;

        }


        public async Task UpdateHotel(int id, [Bind("ID,Name,StreetAdress,City,State,Phone")] Hotel hotel)
        {
            _context.Update(hotel);
            await _context.SaveChangesAsync();
        }


    }
}
