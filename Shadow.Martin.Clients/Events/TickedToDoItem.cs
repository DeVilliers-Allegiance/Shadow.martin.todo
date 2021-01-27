using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadow.Martin.Clients.Domain.Events
{
    public record TickedToDoItem(int clId,int todoId)
    {

    }
}
