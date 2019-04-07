namespace AsyncInn.Models
{
    public class Amenities
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public RoomAmenities RoomAmenities { get; set; }
    }
}