using DemosTask.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemosTask.Models;
using System.Runtime.InteropServices.ComTypes;

namespace DemoTask.Tests
{
    [TestClass]
    public class UnitTestController
    {
        private readonly CinemaContext context;

        [TestMethod]
        public async void GetTest() //
        {
            // Arrange
            var controller = new CinemasController(context);

            // Act
            var resultGET = await controller.GetCinema(3);

            // Assert
            Assert.IsNotNull(resultGET);
        }

        [TestMethod]
        public async void PostMethod()
        {
            // Arrange
            var controller = new CinemasController(context);

            var cinema_post = new Cinema { Name = "Vivas", Rating = 7, Price = 10, Time = 100 };

            // Act
            var resultCreate = await controller.PostCinema(cinema_post);

            // Assert
            Assert.IsNotNull(resultCreate);
        }

        [TestMethod]
        public async void PutMethod()
        {
            // Arrange
            var controller = new CinemasController(context);

            var cinema_post = new Cinema { Name = "Vivas", Rating = 7, Price = 10, Time = 100 };
            var cinema_put = new Cinema { Name = "Vi", Rating = 71, Price = 110, Time = 1100 };

            // Act
            var resultGET = await controller.GetCinema(3);
            var resultEdit = await controller.PutCinema(3, cinema_put);

            // Assert
            Assert.AreNotEqual(resultGET, resultEdit);
        }

        [TestMethod]
        public async void EditMethod()
        {
            // Arrange
            var controller = new CinemasController(context);

            var cinema_post = new Cinema { Name = "Vivas", Rating = 7, Price = 10, Time = 100 };
            var cinema_put = new Cinema { Name = "Vi", Rating = 71, Price = 110, Time = 1100 };

            // Act
            var resultGET = await controller.GetCinema(3);
            var resultEdit = await controller.PutCinema(3, cinema_put);

            // Assert
            Assert.AreNotEqual(resultGET, resultEdit);
        }
    }
}
