using Domain.Entities;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IPetShopRepository
    {
        public IEnumerable<Client> GetClients();
    }
}
