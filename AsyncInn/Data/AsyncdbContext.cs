using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncInn.Models;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;
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
            modelBuilder.Entity<HotelRoom>().HasKey(ce => new { ce.HotelID, ce.RoomNumber });
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

                },
                new Hotel
                {
                    ID = 3,
                    Name = "TestHotel3",
                    StreetAdress = "0002 Fake Addy",
                    City = "Seattle",
                    State = "Washington",
                    Phone = 1111234567,

                },
                new Hotel
                {
                    ID = 4,
                    Name = "TestHotel4",
                    StreetAdress = "0003 Fake Addy",
                    City = "Seattle",
                    State = "Washington",
                    Phone = 221234567,

                },
                new Hotel
                {
                    ID = 5,
                    Name = "TestHotel5",
                    StreetAdress = "0004 Fake Addy",
                    City = "Seattle",
                    State = "Washington",
                    Phone = 331234567,

                },
                new Hotel
                {
                    ID = 6,
                    Name = "TestHotel6",
                    StreetAdress = "0005 Fake Addy",
                    City = "Seattle",
                    State = "Washington",
                    Phone = 441234567,

                });
            modelBuilder.Entity<Room>().HasData(
                new Room
                {
                    ID = 1,
                    Name = "Red",
                    RoomLayout = Models.Room.Layout.Studio

                },
                new Room
                {
                    ID = 2,
                    Name = "Blue",
                    RoomLayout = Models.Room.Layout.Studio

                },
                new Room
                {
                    ID = 3,
                    Name = "Green",
                    RoomLayout = Models.Room.Layout.OneBedroom

                },
                new Room
                {
                    ID = 4,
                    Name = "Yellow",
                    RoomLayout = Models.Room.Layout.OneBedroom

                },
                new Room
                {
                    ID = 5,
                    Name = "Orange",
                    RoomLayout = Models.Room.Layout.TwoBedroom

                },
                new Room
                {
                    ID = 6,
                    Name = "Purple",
                    RoomLayout = Models.Room.Layout.TwoBedroom

                });
            modelBuilder.Entity<Amenities>().HasData(
                new Amenities
                {
                    ID = 1,
                    Name = "Heating"
                },
                new Amenities
                {
                    ID = 2,
                    Name = "In-Unit Laundry"
                },
                new Amenities
                {
                    ID = 3,
                    Name = "Pool"
                },
                new Amenities
                {
                    ID = 4,
                    Name = "Balcony"
                },
                new Amenities
                {
                    ID = 5,
                    Name = "WiFi"
                });


            /*
            modelBuilder.Entity<HotelRoom>().HasData(
                new HotelRoom
                {
                    HotelID = 1,
                    PetFriendly = false,
                    Rate = 1250,
                    RoomNumber = 001,
                    Hotel = new Hotel(),
                    RoomID = 100
                },
                new HotelRoom
                {
                    HotelID = 2,
                    PetFriendly = false,
                    Rate = 1300,
                    RoomNumber = 002,
                    Hotel = new Hotel(),
                    RoomID = 101
                },
                new HotelRoom
                {
                    HotelID = 3,
                    PetFriendly = true,
                    Rate = 1400,
                    RoomNumber = 003,
                    Hotel = new Hotel(),
                    RoomID = 102
                },
                new HotelRoom
                {
                    HotelID = 4,
                    PetFriendly = true,
                    Rate = 1450,
                    RoomNumber = 004,
                    Hotel = new Hotel(),
                    RoomID = 103
                }
                );
            modelBuilder.Entity<RoomAmenities>().HasData(
                new RoomAmenities
                {
                    AmenitiesID = 1,

                    RoomID = 1,
                    Amenities = new Amenities(),
                    Room = new Room()




                },
                new RoomAmenities
                {
                    AmenitiesID = 2,

                    RoomID = 2,
                    Amenities = new Amenities(),
                    Room = new Room()


                },
                new RoomAmenities
                {
                    AmenitiesID = 3,

                    RoomID = 3,
                    Amenities = new Amenities(),
                    Room = new Room()

                },
                new RoomAmenities
                {
                    AmenitiesID = 4,

                    RoomID = 4,
                    Amenities = new Amenities(),
                    Room = new Room()
                   
                }
                );
        */

        }

        //public DbSet<MODELNAME> TABLENAME { get; set; }
        public DbSet<Hotel> Hotel { get; set; }

        public DbSet<HotelRoom> HotelRoom { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
        public DbSet<Amenities> Amenities { get; set; }




    }
}
