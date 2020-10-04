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
        public async void TestMethod1() //
        {
            // Arrange
            var controller = new CinemasController(context);

            var cinema_post = new Cinema { Name = "Vivas", Rating = 7, Price = 10, Time = 100 };
            var cinema_put = new Cinema { Name = "Vi", Rating = 71, Price = 110, Time = 1100 };

            // Act
            var resultGET = await controller.GetCinema(3);
            var resultDelete = await controller.DeleteCinema(1);
            var resultCreate = await controller.PostCinema(cinema_post);
            var resultEdit = await controller.PutCinema( 3 , cinema_put);

            // Assert
            Assert.IsNull(resultDelete);
            Assert.IsNotNull(resultCreate);
            Assert.AreNotEqual(resultGET, resultEdit);
            Assert.IsNotNull(resultGET);
        }

        [TestMethod]
        public async void TestMethod2()
        {
            // Arrange
            var controller = new CinemasController(context);

            var cinema_post = new Cinema { Name = "Vivas", Rating = 7, Price = 10, Time = 100 };
            var cinema_put = new Cinema { Name = "Vi", Rating = 71, Price = 110, Time = 1100 };

            // Act
            var resultGET = await controller.GetCinema(3);
            var resultDelete = await controller.DeleteCinema(1);
            var resultCreate = await controller.PostCinema(cinema_post);
            var resultEdit = await controller.PutCinema(3, cinema_put);

            // Assert
            Assert.IsNull(resultDelete);
            Assert.IsNotNull(resultCreate);
            Assert.AreNotEqual(resultGET, resultEdit);
            Assert.IsNotNull(resultGET);
        }
    }
}
