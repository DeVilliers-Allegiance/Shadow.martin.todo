using Shadow.Martin.Clients;
using Shadow.Martin.Clients.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.martin.clients.infrastructure
{
    public interface IEventService
    {
        Task AppendToEventStore(AggregateRoot aggregateRoot, string streamName);
        Task<Client> GetClient(Guid clientId);
    }
}

