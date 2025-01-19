using Practy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practy.Core.Services
{
    public interface IClientService
    {
        List<Client> GetList();

        Client? GetById(int id);

        Client Add(Client client);

        Client Update(Client client);

        void Delete(int id);
    }
}
