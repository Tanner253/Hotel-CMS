using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Room
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter a valid name")]

        public string Name { get; set; }
        [Required(ErrorMessage ="You forgot to fill this out!")]
        [Display(Name = "Room Layout")]
        public Layout RoomLayout { get; set; }



        //nav
        [Required(ErrorMessage ="Please select a hotel Room")]
        public HotelRoom HotelRoom { get; set; }
        public RoomAmenities RoomAmenities { get; set; }

        public enum Layout
        {
            Studio,
            OneBedroom,
            TwoBedroom
        }
    }
}
