using Data.DataAcces;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class SaleDetailRepository
    {
        private SqlDataAccess _db;

        public IQueryable<SaleDetail> GetSaleDetail()
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM SaleDetail";

            return _db.GetData<SaleDetail, dynamic>(sqlString, new { });

        }
        public SaleDetail GetSaleDetailById(int Id)
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM SaleDetail WHERE Id = @Id";

            var result = _db.GetData<SaleDetail, dynamic>(sqlString, new { Id = Id });
            return result.FirstOrDefault();

        }
        public IQueryable<SaleDetail> GetSaleDetailBySaleId(int SaleId)
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM SaleDetail WHERE SaleId = @SaleId";

            var result = _db.GetData<SaleDetail, dynamic>(sqlString, new { SaleId = SaleId });
            return result;

        }
        public int InsertSaleDetail(SaleDetail saleDetail)
        {
            _db = new SqlDataAccess();
            int saleDetailId;
            string sqlString = "INSERT INTO [dbo].[SaleDetail] " +
                                       " ([ProductId] " +
                                       " ,[Quantity] " +
                                       " ,[SaleId]) " +
                                 " VALUES " +
                                       " (@ProductId " +
                                       " , @Quantity " +
                                       " , @SaleId)";

            saleDetailId = _db.SaveDataReturnIdentity(sqlString, new
            {
                saleDetail.ProductId,
                saleDetail.Quantity,
                saleDetail.SaleId
            });

            return saleDetailId;
        }

        public int UpdateSaleDetail(SaleDetail saleDetail)
        {
            _db = new SqlDataAccess();
            string sqlString = " UPDATE [dbo].[SaleDetail] SET ProductId = @ProductId," +
                               " Quantity = @Quantity, SaleId  = @SaleId, " +
                               "WHERE Id = @Id";


            var saleDetailId = _db.SaveData(sqlString, new
            {
                saleDetail.ProductId,
                saleDetail.Quantity,
                saleDetail.SaleId
            });

            return saleDetailId;
        }
    }
}
