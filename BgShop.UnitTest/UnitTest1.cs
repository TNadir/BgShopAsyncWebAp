using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BgShop.Api.Controllers;
using BgShop.Data.Model;
using BgShop.Data.Repository;
using BgShop.Data.Services.Game;
using BgShop.Domen.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BgShop.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Should_Return_Games()
        {
            // Arrange.

            var data = new List<Games>
            {
                new Games { id=1, duration =2, featured =true, players ="1-5", price = 50, publisherid = 1, thumbnail = "wewqe"},
                new Games { id=2, duration =5, featured =true, players ="1-54", price = 520, publisherid = 2, thumbnail = "wexcvxcvwqe"},
                new Games { id=3, duration =2, featured =true, players ="1-35", price = 45, publisherid = 1, thumbnail = "wewxcvcvqe"}
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Games>>();
            mockSet.As<IQueryable<Games>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Games>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Games>>().Setup(m => m.ElementType).Returns(data.ElementType);
          //  mockSet.As<IQueryable<Games>>().Setup(m => m.GetEnumerator()).Returns(0 =>data.GetEnumerator());

            var mockContext = new Mock<ApplicationContext>();
            mockContext.Setup(c => c.Games).Returns(mockSet.Object);

            var repo=new Mock<IRepository<Games>>(mockContext);
            var service = new GameService(repo.Object);
            var games = service.GetAllGames();

            Assert.AreEqual(3, games.Result.ToList().Count);
           

        }




    }
}
