using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncInn.Models;
using System.ComponentModel.DataAnnotations;

namespace AsyncInn.Models
{
    public class HotelRoom 
    {
        [Required(ErrorMessage ="Please select a hotel")]
        public int HotelID { get; set; }
        [Required(ErrorMessage = "Please select a room")]
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Please select a Room Number")]
        public int RoomNumber { get; set; }
        [Required(ErrorMessage = "Please select a Rate")]
        public int Rate { get; set; }
        public bool PetFriendly { get; set; }




        //navigation

        public Hotel Hotel { get; set; }
        public Room Room { get; set; }

    }
}
