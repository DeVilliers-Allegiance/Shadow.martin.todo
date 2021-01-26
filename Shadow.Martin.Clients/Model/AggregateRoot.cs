using System;
using System.Collections.Generic;
using System.Text;

namespace Shadow.Martin.Clients.Domain
{
    public abstract class AggregateRoot
    {

        public List<Event> MyProperty { get; set; }
    }
}
