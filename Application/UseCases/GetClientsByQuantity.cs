using Application.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.UseCases
{
    public class GetClientsByQuantity
    {
        private readonly IPetShopRepository _repository;

        public GetClientsByQuantity(IPetShopRepository repository)
        {
            _repository = repository ?? throw new System.ArgumentNullException(nameof(repository));
        }

        public IEnumerable<Client> Handle(int quantity)
        {
            if(quantity < 0) { throw new ArgumentException(); }

            var clients = _repository.GetClients();

            return clients.Where(c => c.Quantity == quantity);

        }
    }
}
