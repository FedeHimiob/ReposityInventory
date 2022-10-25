using Data.DataAcces;
using Data.Entities;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class SaleRepository
    {
        private SqlDataAccess _db;

        public IQueryable<Sale> GetSale()
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM Sale";

            return _db.GetData<Sale, dynamic>(sqlString, new { });

        }
        public IQueryable<ModelSalesMade> GetSalesMade()
        {
            _db = new SqlDataAccess();
            string sqlString;

            sqlString = "select s.Id, c.Id as IdClient, s.InVoice, s.SaleDate, c.Name,"+
                        " isnull((select distinct sum((p.Price*sd.Quantity)*1.15)"+
                        " from  Products p inner join SaleDetail sd on p.Id = sd.ProductId " +
                        "and sd.SaleId = s.Id),0) as Monto"+
                        " from Sale s inner join Client c on c.Id = s.IdClient";

            return _db.GetData<ModelSalesMade, dynamic>(sqlString, new { });

        }
        public Sale GetSaleById(int Id)
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM Sale WHERE Id = @Id";

            var result = _db.GetData<Sale, dynamic>(sqlString, new { Id = Id });
            return result.FirstOrDefault();

        }
        public Sale GetSaleByInVoice(string inVoice)
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM Sale WHERE InVoice = @InVoice";

            var result = _db.GetData<Sale, dynamic>(sqlString, new { InVoice = inVoice });
            return result.FirstOrDefault();

        }
        public int InsertSale(Sale sale)
        {
            _db = new SqlDataAccess();
            int saleId;
            string sqlString = "INSERT INTO [dbo].[Sale] " +
                                       " ([InVoice] " +
                                       " ,[IdClient] " +
                                       " ,[Comment] " +
                                       " ,[SaleDate] " +
                                       " ,[PuerchaseType] " +                                       
                                       " ,[PaymentStatus]) " +
                                 " VALUES " +
                                       " (@InVoice " +
                                       " , @IdClient " +
                                       " , @Comment " +
                                       " , @SaleDate " +
                                       " , @PuerchaseType " +                                      
                                       " , @PaymentStatus)";

            saleId = _db.SaveDataReturnIdentity(sqlString, new
            {
                sale.IdClient,
                sale.InVoice,
                sale.Comment,
                sale.SaleDate,
                sale.PuerchaseType,
                sale.PaymentStatus
                
            });

            return saleId;
        }
        public int UpdateSale(Sale sale)
        {
            _db = new SqlDataAccess();
            string sqlString = " UPDATE [dbo].[Sale] SET InVoice = @InVoice," +
                               " Comment = @Comment, " +
                               "SaleDate  = @SaleDate " +
                               "IdClient  = @IdClient " +
                               " PuerchaseType = @PuerchaseType, " +
                               "PaymentStatus  = @PaymentStatus, " +                               
                               "WHERE Id = @Id";


            var saleId = _db.SaveData(sqlString, new
            {
                sale.Id,
                sale.IdClient,
                sale.InVoice,
                sale.Comment,
                sale.SaleDate,
                sale.PuerchaseType,
                sale.PaymentStatus
                
            });

            return saleId;
        }

        public int DeleteSale(int Id)
        {
            _db = new SqlDataAccess();
            string sqlString = "DELETE FROM [dbo].[sale] WHERE Id = @Id";

            var result = _db.SaveData(sqlString, new { Id });

            return result;
        }
    }
}
