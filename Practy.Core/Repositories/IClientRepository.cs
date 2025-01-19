using Practy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practy.Core.Repositories
{
    public interface IClientRepository
    {
        List<Client> GetAll();

        Client? GetById(int id);

        Client Add(Client client);

        Client Update(Client client);

        void Delete(int id);
    }
}
