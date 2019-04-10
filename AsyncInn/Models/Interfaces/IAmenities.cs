using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IAmenities
    {
        Task CreateAmenitie(Amenities amenities);

        Task UpdateAmenitie(int id, Amenities amenities);

        Task<Amenities> DeleteAmenitie(int id);

        Task DeleteAmenitieFR(int id);

        Task<Amenities> GetAmenitie(int id);

        Task<IEnumerable<Amenities>> GetAmenities();

        bool AmenitiesExists(int id);
    }
}
