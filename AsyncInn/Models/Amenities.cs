using System.ComponentModel.DataAnnotations;

namespace AsyncInn.Models
{
    public class Amenities
    {
        public int ID { get; set; }
        /// <summary>
        /// sets names
        /// </summary>
        [Required(ErrorMessage = "Please enter a valid name")]
        public string Name { get; set; }

        public RoomAmenities RoomAmenities { get; set; }
    }
}