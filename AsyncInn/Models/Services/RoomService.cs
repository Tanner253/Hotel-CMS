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
    public class RoomService : IRoom 
    {
        private AsyncdbContext _context;

        public RoomService(AsyncdbContext context)
        {
            _context = context;
        }
        
        public async Task<Room> DeleteRoom(int id)
        {
            Room room = await _context.Room
                           .FirstOrDefaultAsync(m => m.ID == id);
            return room;
        }

        public async Task<Room> GetRoom(int id)
        {
            var room = await _context.Room.FindAsync(id);
            if (room == null)
            {
                return null;
            }

            return room;
        }

        public async Task<IEnumerable<Room>> GetRooms()
        {
            return await _context.Room.ToListAsync();
        }

        public async Task CreateRoom([Bind("ID,Name,RoomLayout")]Room hotel)
        {
            _context.Add(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateRoom(int id, [Bind("ID,Name,RoomLayout")] Room hotel)
        {
            _context.Update(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoomFR(int id)
        {
            var room = await _context.Room.FindAsync(id);
            _context.Room.Remove(room);
            await _context.SaveChangesAsync();
        }

        public bool RoomExists(int id)
        {
            return _context.Hotel.Any(e => e.ID == id);
        }
    }
}
