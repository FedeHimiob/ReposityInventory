using Data.Entities;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Servicies
{
    public class ClientService
    {
        public IQueryable<Client> GetClient()
        {
            ClientRepository repo = new ClientRepository();
            var result = repo.GetClients();
            return result;
        }

        public Client GetClientById(int Id)
        {
            ClientRepository repo = new ClientRepository();
            var result = repo.GetClientById(Id);
            return result;
        }

        public Client GetClientByDocumentIdentity(string documentIdentity)
        {
            ClientRepository repo = new ClientRepository();
            var result = repo.GetClientByDocumentIdentity(documentIdentity);
            return result;
        }

        public int SaveClient(Client client)
        {
            ClientRepository repo = new ClientRepository();
            Client c= new Client();
            int result = 0;

            if (client.Id > 0)
            {
                c = repo.GetClientById(client.Id);
                //if (c != null)
                //{
                //    result = repo.UpdateProduct(product);
                //}
            }
            else
            {
                result = repo.InsertClient(client);
            }

            return result;
        }

    }
}
