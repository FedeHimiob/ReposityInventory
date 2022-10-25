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
    public class ProductsEntryRepository
    {
        private SqlDataAccess _db;

        public IQueryable<ProductsEntry> GetProductsEntry()
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM ProductsEntry";

            return _db.GetData<ProductsEntry, dynamic>(sqlString, new { });

        }
        public IQueryable<InventoryModel> GetTotalInventory()
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = 
                
                "SELECT  Distinct p.Id, p.Name, p.Price, p.Description, "+
                
                "Isnull((SELECT SUM(peq.Quantity) FROM ProductsEntry peq where peq.ProductId = p.Id and peq.IsEntry = 1  GROUP BY peq.ProductId),0)   " +
                "as 'CantidadEntrada',"+

                "(Isnull((SELECT SUM(peq.Quantity) FROM ProductsEntry peq where peq.ProductId = p.Id and peq.IsEntry = 0  GROUP BY peq.ProductId),0)"+
				"+ (Isnull((Select sum(Quantity) from SaleDetail sd where sd.ProductId = p.Id), 0))"+
				") as 'CantidadSalida',"+ 



                "(Isnull((SELECT SUM(peq.Quantity) FROM ProductsEntry peq where peq.ProductId = p.Id and peq.IsEntry = 1  GROUP BY peq.ProductId),0) - " +
                
                "(Isnull((SELECT SUM(peq.Quantity) FROM ProductsEntry peq where peq.ProductId = p.Id and peq.IsEntry = 0  GROUP BY peq.ProductId),0) " +
               
                "+(Isnull((Select sum(Quantity) from SaleDetail sd where sd.ProductId = p.Id),0)" +
                ")))as 'CantidadDisponible'"+
               
                "FROM Products p "+
                "LEFT JOIN ProductsEntry pe on p.Id = pe.ProductId "+
                "WHERE p.IsActive = 1";

            return _db.GetData<InventoryModel, dynamic>(sqlString, new { });

        }

        public IQueryable<HistoricalModel> GetHistoricalProductEntries(int ProductId)
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString =

                "SELECT pe.Id, pe.EntryDate," +
                "Isnull((select peq.Quantity from ProductsEntry peq where peq.ProductId = pe.ProductId and peq.IsEntry = 1 and peq.Id = pe.Id),0) as Entrada," +
                "Isnull((select peq.Quantity from ProductsEntry peq where peq.ProductId = pe.ProductId and peq.IsEntry = 0 and peq.Id = pe.Id),0) as Salida" +
                " from ProductsEntry pe where pe.ProductId = @ProductId ";

            return _db.GetData<HistoricalModel, dynamic>(sqlString, new { ProductId = ProductId });

        }


        public ProductsEntry GetProductsEntryById(int Id)
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM ProductsEntry WHERE Id = @Id";

            var result = _db.GetData<ProductsEntry, dynamic>(sqlString, new { Id = Id });
            
            return result.FirstOrDefault();

        }
       public IQueryable<ProductsEntry> GetProductsEntryByProductId(int ProductId)
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM ProductsEntry WHERE ProductId = @ProductId";

            var result = _db.GetData<ProductsEntry, dynamic>(sqlString, new { ProductId = ProductId });

            return result;
        }

        public int InsertProductsEntry(ProductsEntry productsEntry)
        {
            _db = new SqlDataAccess();
            int productsEntryId;
            string sqlString = "INSERT INTO [dbo].[ProductsEntry] " +
                                       " ([Quantity] " +
                                        " ,[ProductId] " +
                                       " ,[IsEntry] " +
                                       " ,[EntryDate])" +
                                 " VALUES " +
                                       " (@Quantity " +
                                       " , @ProductId " +
                                       " , @IsEntry " +
                                       " , @EntryDate )";

            productsEntryId = _db.SaveDataReturnIdentity(sqlString, new
            {
               productsEntry.Quantity,
               productsEntry.IsEntry,
               productsEntry.EntryDate,
               productsEntry.ProductId
            });

            return productsEntryId;
        }

        public int UpdateProductsEntry(ProductsEntry productsEntry)
        {
            _db = new SqlDataAccess();
            string sqlString = " UPDATE [dbo].[ProductsEntry] SET Quantity = @Quantity," +
                               " IsEntry = @IsEntry, EntryDate  = @EntryDate " +
                               " WHERE Id = @Id";


            var productsEntryId = _db.SaveData(sqlString, new
            {
                productsEntry.Id,
               // productsEntry.ProductId,
                productsEntry.Quantity,
                productsEntry.IsEntry,
                productsEntry.EntryDate
            });

            return productsEntryId;
        }

        public int DeleteProductsEntry(int Id)
        {
            _db = new SqlDataAccess();
            string sqlString = "DELETE FROM [dbo].[ProductsEntry] WHERE Id = @Id";

            var result = _db.SaveData(sqlString, new { Id });

            return result;
        }
    }
}
