using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IRoom
    {
        Task CreateRoom(Room hotel);

        Task UpdateRoom(int id, Room hotel);

        Task<Room> DeleteRoom(int id);

        Task DeleteRoomFR(int id);

        //  Hotel ThisHotel(int id);

        Task<Room> GetRoom(int id);

        Task<IEnumerable<Room>> GetRooms();

        bool RoomExists(int id);
    }
}
