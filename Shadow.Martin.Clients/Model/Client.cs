using Shadow.Martin.Clients.Domain;
using Shadow.Martin.Clients.Domain.Model;
using System;
using System.Collections.Generic;

namespace Shadow.Martin.Clients
{
    public record Client
    {
        private Client()
        {

        }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public DateTime dateOfBirth { get; private set; }
        public List<ToDo> ToDos { get; set; }
    }
}
