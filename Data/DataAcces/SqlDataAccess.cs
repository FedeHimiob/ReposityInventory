using Dapper;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Data.DataAcces
{
    public class SqlDataAccess
    {
        private string _config;
        public SqlDataAccess()
        {
            _config = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        public IQueryable<T> GetData<T, U>(string sqlString, U parameters, string connectionId = "Default")
        {
            try
            {
                using (IDbConnection connection = new SqlConnection(_config))
                {
                    var result = connection.Query<T>(sqlString, parameters, commandType: CommandType.Text);
                    return result.AsQueryable();
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int SaveData<T>(string sqlString, T parameters, string connectionId = "Default")
        {
            int result;
            using (IDbConnection connection = new SqlConnection(_config))
            {
                result = connection.Execute(sqlString, parameters, commandType: CommandType.Text);
            }

            return result;
        }

        public int SaveDataReturnIdentity<T>(string sqlString, T parameters, string connectionId = "Default")
        {
            int result;
            using (IDbConnection connection = new SqlConnection(_config))
            {
                result = connection.ExecuteScalar<int>(sqlString, parameters, commandType: CommandType.Text);
            }

            return result;
        }

    }
}
