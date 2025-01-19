using Practy.Core.Entities;
using Practy.Core.Repositories;
using Practy.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practy.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public List<Client> GetList()
        {
            return _clientRepository.GetAll();
        }

        public Client? GetById(int id)
        {
            return _clientRepository.GetById(id);
        }

        public Client Add(Client user)
        {
            return _clientRepository.Add(user);
        }

        public Client Update(Client user)
        {
            return _clientRepository.Update(user);
        }

        public void Delete(int id)
        {
            _clientRepository.Delete(id);
        }
    }
}
