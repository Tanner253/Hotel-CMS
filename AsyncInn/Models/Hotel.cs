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
        public string StreetAdress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }


        //connection string
        public HotelRoom HotelRoom { get; set; }

    }
}
