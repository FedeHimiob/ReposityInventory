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
    public class ReceivableRepository
    {
        private SqlDataAccess _db;

        public IQueryable<Receivable> GetReceivable()
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM Receivable";

            return _db.GetData<Receivable, dynamic>(sqlString, new { });
        }
        public IQueryable<ReceivableModel> GetReceivableMade()
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString =     "select r.Id as IdReceivable, s.Id as IdSale, c.Id as IdClient, " +
                            "s.InVoice, s.SaleDate, c.Name, " +
                            "isnull((select distinct sum((p.Price*sd.Quantity)*1.15) from  Products p "+
                            "inner join SaleDetail sd on p.Id = sd.ProductId and sd.SaleId = s.Id),0) as MontoTotal, "+
                            "r.PaidAmount, r.TotalAmount "+
                            "from Sale s inner join Client c on c.Id = s.IdClient "+
                            "inner join Receivable r on s.Id = r.SaleId";

            return _db.GetData<ReceivableModel, dynamic>(sqlString, new { });
        }
        public Receivable GetReceivableById(int Id)
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM Receivable WHERE Id = @Id";

            var result = _db.GetData<Receivable, dynamic>(sqlString, new { Id = Id });
            return result.FirstOrDefault();

        }
        public Receivable GetReceivableBySaleId(int SaleId)
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM Receivable WHERE SaleId = @SaleId";

            var result = _db.GetData<Receivable, dynamic>(sqlString, new { SaleId = SaleId });
            return result.FirstOrDefault();

        }

        public int InsertReceivable(Receivable receivable)
        {
            _db = new SqlDataAccess();
            int receivableId;
            string sqlString = "INSERT INTO [dbo].[Receivable] " +
                                       " ([SaleId] " +
                                       " ,[TotalAmount] " +
                                       " ,[PaidAmount]) " +
                                 " VALUES " +
                                       " (@SaleId " +
                                       " , @TotalAmount " +
                                       " , @PaidAmount)";

            receivableId = _db.SaveDataReturnIdentity(sqlString, new
            {
                receivable.SaleId,
                receivable.TotalAmount,
                receivable.PaidAmount
            });

            return receivableId;
        }

        public int UpdateReceivable(Receivable receivable)
        {
            _db = new SqlDataAccess();
            string sqlString = " UPDATE [dbo].[Receivable] SET SaleId = @SaleId," +
                               " TotalAmount = @TotalAmount, PaidAmount  = @PaidAmount, " +
                               "WHERE Id = @Id";


            var receivableId = _db.SaveData(sqlString, new
            {
                receivable.SaleId,
                receivable.TotalAmount,
                receivable.PaidAmount
            });
            return receivableId;
        }
    }
}

