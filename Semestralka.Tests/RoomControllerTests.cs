using Microsoft.AspNetCore.Mvc;
using SemestralkaDataControl.Models;
using SemestralkaDataControl.Repo;
using Moq;
using Xunit;
using System.Collections.Generic;
using System.Linq;
using Semestralka.Controllers;
using SemestralkaDataControl.EF;

namespace Semestralka.Tests
{
    public class RoomControllerTests
    {
        [Fact]
        public void CheckIfIndexResultIsNotNull()
        {
            var context = new Mock<ApplicationContext>();
            var mock = new Mock<RoomRepo>(context.Object);
            RoomsController controller = new RoomsController(mock.Object);

            ViewResult result = controller.Index(null) as ViewResult;

            Assert.NotNull(result);
        }

       
        [Fact]
        public void CheckIfDetailsReturnsNotFound()
        {
            var context = new Mock<ApplicationContext>();
            var mock = new Mock<RoomRepo>(context.Object);
            RoomsController controller = new RoomsController(mock.Object);

            NotFoundResult result = controller.Details(null, null) as NotFoundResult;

            Assert.IsType<NotFoundResult>(result);
        }


    }
}
