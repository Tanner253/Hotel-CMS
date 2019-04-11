using System;
using Xunit;
using AsyncInn.Models;
using AsyncInn.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
        /*[Fact]
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

        }*/
    }
}
