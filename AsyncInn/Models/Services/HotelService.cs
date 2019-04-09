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

        public async Task DeleteHotel(int? id)
        {
           
            var hotel = await _context.Hotel
                .FirstOrDefaultAsync(m => m.ID == id);
        }

        public async Task<Hotel> GetHotel(int id)
        {
            var course = await _context.Hotel.FindAsync(id);
            if (course == null)
            {
                return null;
            }

            return course;
        }

        public async Task<List<Hotel>> GetHotels()
        {
            return await _context.Hotel.ToListAsync();
        }

        public HotelRoom HotelRoom(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateHotel(int id, [Bind("ID,Name,StreetAdress,City,State,Phone")] Hotel hotel)
        {



            _context.Update(hotel);
            await _context.SaveChangesAsync();




            
        }


    }
}
