using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Repository
{
    public static class Source
    {
        public static List<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client()
                {
                    Id = 1,
                    Name = "Name 1",
                    Quantity = 4
                },
                new Client()
                {
                    Id = 1,
                    Name = "Name 1",
                    Quantity = 4
                },
                new Client()
                {
                    Id = 1,
                    Name = "Name 1",
                    Quantity = 8
                },
                new Client()
                {
                    Id = 1,
                    Name = "Name 1",
                    Quantity = 1
                },
            };
        }
    }
}
