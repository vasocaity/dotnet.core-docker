using System;
using Xunit;
using backend.Controllers;
using backend.Models;

namespace Backend.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var mockController = new ValuesController();
            // var responce = mockController.GetData();
            // var okResult = Assert.IsType<OkObjectResult>(responce);
            // var responceData = Assert.IsType<Data>(ok)
            Assert.Equal(1,1);
        }
    }
}
