using System.ComponentModel.DataAnnotations;

namespace AsyncInn.Models
{
    public class RoomAmenities
    {
        [Required()]
        public int AmenitiesID { get; set; }
        [Required()]

        public int RoomID { get; set; }





        public Room Room { get; set; }

        public Amenities Amenities { get; set; }
    }
}