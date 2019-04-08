using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
namespace AsyncInn.Data
{
    public class AsyncdbContext : DbContext
    {
        public AsyncdbContext(DbContextOptions<AsyncdbContext> options) : base(options)
        {


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // this is the establishment of our composite key
            modelBuilder.Entity<HotelRoom>().HasKey(ce => new { ce.HotelID, ce.RoomID });
            modelBuilder.Entity<RoomAmenities>().HasKey(ce => new { ce.AmenitiesID, ce.RoomID });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    Name = "TestHotel",
                    StreetAdress = "0000 Fake Addy",
                    City = "Seattle",
                    State = "Washington",
                    Phone = 0001234567,

                },
                new Hotel
            {

                ID = 2,
                Name = "TestHote2",
                StreetAdress = "0001 Fake Addy",
                City = "Seattle",
                State = "Washington",
                Phone = 222222222,

            });
            /*modelBuilder.Entity<HotelRoom>().HasData(
                new HotelRoom
                {
                    HotelID = 1,
                    PetFriendly = false,
                     Rate = 1000,
                      RoomNumber = 001,
                       Hotel = new Hotel(),
                        RoomID = 1


                        

                    

                    
                }
                );*/
        }

        //public DbSet<MODELNAME> TABLENAME { get; set; }
        public DbSet<Hotel> Hotel { get; set; }

        public DbSet<HotelRoom> HotelRoom { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public DbSet<Amenities> Amenities { get; set; }




    }
}
