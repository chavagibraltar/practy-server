using Practy.Core.Entities;
using Practy.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practy.Data.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly DataContext _context;

        public ClientRepository(DataContext context)
        {
            _context = context;
        }

        public List<Client> GetAll()
        {
            return _context.Clients;
        }

        public Client? GetById(int id)
        {
            return _context.Clients.FirstOrDefault(x => x.Id == id);
        }

        public Client Add(Client client)
        {
            _context.Clients.Add(client);
            return client;
        }

        public Client Update(Client client)
        {
            var existingClient = GetById(client.Id);
            if (existingClient is null)
            {
                throw new Exception("Client not found");
            }
            existingClient.Tz = client.Tz;
            existingClient.FirstName = client.FirstName;
            existingClient.LastName = client.LastName;
            existingClient.Phone = client.Phone;
            existingClient.Email = client.Email;
            existingClient.Address = client.Address;
            return existingClient;
        }

        public void Delete(int id)
        {
            var existingClient = GetById(id);
            if (existingClient is not null)
            {
                _context.Clients.Remove(existingClient);
            }
        }
    }
}
