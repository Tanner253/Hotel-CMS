using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IHotelManager
    {
        Task CreateHotel(Hotel hotel);

        Task UpdateHotel(int id, Hotel hotel);

        Task DeleteHotel(int? id);
        

        HotelRoom HotelRoom(int id);

        Task<Hotel> GetHotel(int id);

        Task<List<Hotel>> GetHotels();





    }
}
