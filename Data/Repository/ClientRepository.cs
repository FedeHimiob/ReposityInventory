using Data.DataAcces;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ClientRepository
    {
        private SqlDataAccess _db;

        public IQueryable<Client> GetClients()
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM Client";

            return _db.GetData<Client, dynamic>(sqlString, new { });

        }

        public Client GetClientById(int Id)
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM Client WHERE Id = @Id";

            var result = _db.GetData<Client, dynamic>(sqlString, new { Id = Id });
            return result.FirstOrDefault();

        }
        public Client GetClientByDocumentIdentity(string documentIdentity)
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM Client WHERE DocumentIdentity = @DocumentIdentity";

            var result = _db.GetData<Client, dynamic>(sqlString, new { DocumentIdentity = documentIdentity });
            return result.FirstOrDefault();

        }

        public int InsertClient(Client client)
        {
            _db = new SqlDataAccess();
            int clientId;
            string sqlString = "INSERT INTO [dbo].[Client] " +
                                       " ([Name] " +
                                       " ,[DocumentIdentity] " +
                                       " ,[Phone])" +
                                 " VALUES " +
                                       " (@Name " +
                                       " , @DocumentIdentity " +
                                       " , @Phone)";

            clientId = _db.SaveDataReturnIdentity(sqlString, new
            {
                client.Name,
                client.DocumentIdentity,
                client.Phone                
            });

            return clientId;
        }
    }
}
