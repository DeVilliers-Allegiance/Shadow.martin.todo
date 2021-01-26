

using EventStore.ClientAPI;
using EventStore.ClientAPI.SystemData;
using Shadow.Martin.Clients;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Text.Json;

namespace Shadow.martin.clients.infrastructure
{
    public class EventService
    {

        //make sure your docker is set up, you have wsl2 set up
        //docker pull eventstore/eventstore
        //docker run --name esdb-node -it -p 2113:2113 -p 1113:1113 eventstore/eventstore:latest --insecure --run-projections=All
        //this image is meant not to be persistent and wiped when docker is closed, not for production!!
    }

    internal class IPEndPointFactory
    {
        public static IPEndPoint DefaultTcp()
        {
            return CreateIPEndPoint(1113);
        }

        private static IPEndPoint CreateIPEndPoint(int port)
        {
            var address = IPAddress.Parse("127.0.0.1");
            return new IPEndPoint(address, port);
        }
    }

    public static class EventStoreConnectionFactory
    {
        public static IEventStoreConnection Default()
        {
            var connection = EventStoreConnection.Create(IPEndPointFactory.DefaultTcp());
            connection.ConnectAsync();
            return connection;
        }
    }

    public class EventStoreCredentials
    {
        private static readonly UserCredentials _credentials =
            new UserCredentials("admin", "changeit");

        public static UserCredentials Default { get { return _credentials; } }
    }
    //public async Task<Client> GetClient(Guid clientId)
    //{
    //    //var events = eventStoreClient.ReadStreamAsync(Direction.Forwards, $"client-{clientId}", StreamPosition.Start);
    //    Client client = null;

    //    await foreach (var ev in events)
    //    {
    //       // client = JsonConvert.DeserializeObject<Client>(Encoding.UTF8.GetString(events.Current.Event.Data.Span));
    //    }

    //    return client;
    //}
}
