using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class Hotel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "This is my custom error message")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "please enter a valid entry")]
        [Display(Name = "Street Address")]
        public string StreetAdress { get; set; }

        [Required(ErrorMessage = "please enter a valid City")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "please enter a valid State")]
        public string State { get; set; }

        [Required(ErrorMessage = "please enter a valid Phone number")]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }


        //connection string

        public ICollection<HotelRoom> HotelRoom { get; set; }


    }
}
