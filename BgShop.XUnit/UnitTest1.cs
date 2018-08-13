using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using BgShop.Api.Controllers;
using BgShop.Data.Repository;
using BgShop.Data.Services.Game;
using BgShop.Domen.Entities;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using  Moq;
namespace BgShop.XUnit
{
    public class UnitTest1
    {
        [Fact]
    
        public void Should_Return_Games()
        {
            // Arrange.
            var gameservie=new Mock<IGameService>();
            var controller = new GameController(gameservie.Object);

            // Act
            var actionResult = controller.GetAll().Result;

            // Assert
            Assert.NotNull(actionResult);

        }
    }
}
