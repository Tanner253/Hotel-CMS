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
            try
            {

            _context = context;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
               
            }
        }

        public async Task CreateHotel(Hotel hotel)
        {
            try
            {
            _context.Add(hotel);
            await _context.SaveChangesAsync();

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }

        public async Task<Hotel> DeleteHotel(int id)
        {
            try
            {

            Hotel hotel = await _context.Hotel
                .FirstOrDefaultAsync(m => m.ID == id);
            return hotel;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return null;
            }


        }
        public async Task DeleteHotelFR(int id)
        {
            try
            {
            var hotel = await _context.Hotel.FindAsync(id);
            _context.Hotel.Remove(hotel);
            await _context.SaveChangesAsync();

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

        }
        

        public async Task<Hotel> GetHotel(int id)
        {
            try
            {

            var hotelrooms = await _context.Hotel
                                           .Include(t => t.HotelRoom)
                                            .ThenInclude(r => r.Room)
                                             .FirstOrDefaultAsync(x => x.ID == id);

            return hotelrooms;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return null;
            }
        }

        public async Task<IEnumerable<Hotel>> GetHotels()
        {
            try
            {

            var hotels = await _context.Hotel.ToListAsync();
            return hotels;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return null;
            }
        }

        public bool HotelExists(int id)
        {
            try
            {
            return _context.Hotel.Any(e => e.ID == id);

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                return false;
            }
        }



        public async Task UpdateHotel(int id, [Bind("ID,Name,StreetAdress,City,State,Phone")] Hotel hotel)
        {
            try
            {
            _context.Update(hotel);
            await _context.SaveChangesAsync();

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                
            }
        }


    }
}
