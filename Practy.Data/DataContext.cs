using Practy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practy.Data
{
    public class DataContext
    {
        public List<Client> Clients { get; set; }
        public DataContext()
        { 
            Clients = new List<Client>
            {
                new Client { Id = 1, Tz = "000000001", FirstName = "Ayala", LastName = "Avramov", Phone = "0504101001",
                    Email="email1@gmail.com", Address = "1 Avrham Ben David street Bney-Brak" },
                new Client { Id = 2, Tz = "000000002", FirstName = "Batya", LastName = "Benedict", Phone = "0504101002",
                    Email="email2@gmail.com", Address = "2 Avrham Ben David street Bney-Brak" },
                new Client { Id = 3, Tz = "000000003", FirstName = "Chana", LastName = "Cohen", Phone = "0504101003",
                    Email="email3@gmail.com", Address = "3 Avrham Ben David street Bney-Brak" }
            };
        }

    }
}
