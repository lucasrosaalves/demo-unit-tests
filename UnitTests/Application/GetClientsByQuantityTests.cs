using Application.Interfaces;
using Application.UseCases;
using Domain.Entities;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitTests.Repository;
using Xunit;

namespace UnitTests.Application
{
    public class GetClientsByQuantityTests
    {
        [Fact]
        public void Handle_ShouldThrowAgumentExceptionIfQuantityLessThan0()
        {
            var repository = new Mock<IPetShopRepository>();

            repository.Setup(s => s.GetClients()).Returns(new List<Client>()
            {
            });

            var service = new GetClientsByQuantity(repository.Object);

            Assert.Throws<ArgumentException>(() => service.Handle(-1));
        }

        [Fact]
        public void Handle()
        {
            var repository = new Mock<IPetShopRepository>();

            repository.Setup(s => s.GetClients()).Returns(Source.GetClients());

            var service = new GetClientsByQuantity(repository.Object);


            var result = service.Handle(4);


            Assert.Equal(2, result.Count());
        }

    }
}
