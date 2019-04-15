using System;
using Xunit;
using AsyncInn.Models;
using AsyncInn.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace XUnitTestHotels
{
    public class UnitTest1
    {
        /* public void CanGetCourse()
        {
            DbContextOptions<StudentEnrollmentDbContext> options = new DbContextOptionsBuilder<StudentEnrollmentDbContext>().UseInMemoryDatabase("CanCreateCourse").Options;

            using (StudentEnrollmentDbContext context = new StudentEnrollmentDbContext(options))
            {
                // Arrange
                Course course = new Course();
                course.Name = "Tap Dancing for Clowns";
                course.Price = 100m;
                course.Tech = Technology.Python;

                context.Add(course);
                context.SaveChanges();

                // Act
                var result = context.Courses.FirstOrDefault(m => m.ID == course.ID);

                // Assert

                Assert.Equal(result, course);


            };
        }*/

        [Fact]
        public void CanGetHotel()
        {
            DbContextOptions<AsyncdbContext> options = new DbContextOptionsBuilder<AsyncdbContext>().UseInMemoryDatabase("CanCreateHotel").Options;

            using (AsyncdbContext context = new AsyncdbContext(options))
            {
                Hotel hotel = new Hotel();


                hotel.ID = 566;
                hotel.Name = "Hotel Name";
                hotel.StreetAdress = "1234 N Address";
                hotel.State = "Alabama";
                hotel.Phone = 1234567;

                context.Add(hotel);
                context.SaveChanges();

                var result = context.Hotel.FirstOrDefault(m => m.ID == hotel.ID);

                Assert.Equal(result, hotel);


            }

        }
         [Fact]
        public void CanGetHotelRoom()
        {
            DbContextOptions<AsyncdbContext> options = new DbContextOptionsBuilder<AsyncdbContext>().UseInMemoryDatabase("CanCreateHotel").Options;

            using (AsyncdbContext context = new AsyncdbContext(options))
            {
                HotelRoom hotelroom = new HotelRoom();
                Hotel hotel = new Hotel();
                Room room = new Room();

                hotelroom.Hotel = hotel;
                hotelroom.HotelID = 1;
                hotelroom.PetFriendly = true;
                hotelroom.Rate = 1200;
                hotelroom.Room = room;
                hotelroom.RoomID = 12;
                hotelroom.RoomNumber = 001;


                context.Add(hotelroom);
                context.SaveChanges();

                var result = context.HotelRoom.FirstOrDefault(m => m.Hotel.ID == hotelroom.HotelID);

                Assert.Equal(result, hotelroom);


            }
        }
             [Fact]
        public void CanGetRoom()
        {
            DbContextOptions<AsyncdbContext> options = new DbContextOptionsBuilder<AsyncdbContext>().UseInMemoryDatabase("CanCreateHotel").Options;

            using (AsyncdbContext context = new AsyncdbContext(options))
            {
                Room room = new Room();
                HotelRoom hotelroom = new HotelRoom();

                room.HotelRoom = hotelroom;
                room.ID = 1;
                room.Name = "Awesomeness";
                room.RoomAmenities = new RoomAmenities();
                room.RoomLayout = 0;




                context.Add(hotelroom);
                context.SaveChanges();

                var result = context.Room.FirstOrDefault(m => m.ID == room.ID);

                Assert.NotEqual(result, room);


            }


        }
        [Fact]
        public void CanGetAmenitie()
        {
            DbContextOptions<AsyncdbContext> options = new DbContextOptionsBuilder<AsyncdbContext>().UseInMemoryDatabase("CanCreateHotel").Options;

            using (AsyncdbContext context = new AsyncdbContext(options))
            {
                Amenities amenities = new Amenities();

                amenities.Name = "Heat";
                amenities.ID = 1;
                amenities.RoomAmenities = new RoomAmenities();






                context.Add(amenities);
                context.SaveChanges();

                var result = context.Amenities.FirstOrDefault(m => m.ID == amenities.ID);

                Assert.Equal(result, amenities);


            }


        }
        //[Fact]
        public void CanGetRoomAmenities()
        {
            DbContextOptions<AsyncdbContext> options = new DbContextOptionsBuilder<AsyncdbContext>().UseInMemoryDatabase("CanCreateHotel").Options;

            using (AsyncdbContext context = new AsyncdbContext(options))
            {
                RoomAmenities roomamenities = new RoomAmenities();

                roomamenities.Amenities = new Amenities();
                roomamenities.AmenitiesID = 1;
                roomamenities.Room= new Room();
                roomamenities.RoomID = 1;






                context.Add(roomamenities);
                context.SaveChanges();

                var result = context.HotelRoom.FirstOrDefault(m => m.Hotel.ID == roomamenities.RoomID);

                Assert.NotEqual(result, roomamenities);


            }


        }
        [Fact]
        public void HotelPropertiesID()
        {
            Hotel hotel = new Hotel();
            var result = hotel.ID = 555;

            Assert.Equal(result, hotel.ID);
        }
        [Fact]
        public void HotelPropertiesName()
        {
            Hotel hotel = new Hotel();
            var result = hotel.Name = "Seattle INN";

            Assert.Equal(result, hotel.Name);
        }
        [Fact]
        public void HotelPropertiesAddress()
        {
            Hotel hotel = new Hotel();
            var result = hotel.StreetAdress = "Seattle 5556 n";

            Assert.Equal(result, hotel.StreetAdress);
        }
        [Fact]
        public void HotelPropertiesCity()
        {
            Hotel hotel = new Hotel();
            var result = hotel.City = "Seattle Area";

            Assert.Equal(result, hotel.City);
        }
        [Fact]
        public void HotelPropertiesState()
        {
            Hotel hotel = new Hotel();
            var result = hotel.State = "Washington";

            Assert.Equal(result, hotel.State);
        }
        [Fact]
        public void HotelPropertiesProperties()
        {
            Hotel hotel = new Hotel();
            var result = hotel.Phone = 123456;

            Assert.Equal(result, hotel.Phone);
        }
        [Fact]
        public void HotelRoomPropertiesHotelID()
        {
            HotelRoom hotelRoom = new HotelRoom();
            var result = hotelRoom.HotelID = 555;
            Assert.Equal(result, hotelRoom.HotelID);
        }
        [Fact]
        public void HotelRoomPropertiesRoomID()
        {
            HotelRoom hotelRoom = new HotelRoom();
            var result = hotelRoom.RoomID = 555;
            Assert.Equal(result, hotelRoom.RoomID);
        }
        [Fact]
        public void HotelRoomPropertiesRoomNumber()
        {
            HotelRoom hotelRoom = new HotelRoom();
            var result = hotelRoom.RoomNumber = 555;
            Assert.Equal(result, hotelRoom.RoomNumber);
        }
        [Fact]
        public void HotelRoomPropertiesRate()
        {
            HotelRoom hotelRoom = new HotelRoom();
            var result = hotelRoom.Rate = 5555;
            Assert.Equal(result, hotelRoom.Rate);
        }
        [Fact]
        public void HotelRoomPropertiesPetFriendly()
        {
            HotelRoom hotelRoom = new HotelRoom();
            var result = hotelRoom.PetFriendly = true;
            Assert.Equal(result, hotelRoom.PetFriendly);
        }
        [Fact]
        public void AmenitiesPropertiesName()
        {
            Amenities amenities = new Amenities();
            var result = amenities.Name = "Heating";
            Assert.Equal(result, amenities.Name);
        }
        [Fact]
        public void AmenitiesPropertiesID()
        {
            Amenities amenities = new Amenities();
            var result = amenities.ID = 5;
            Assert.Equal(result, amenities.ID);
        }

    }
}
