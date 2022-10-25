using Data.DataAcces;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ProductRepository
    {

        private SqlDataAccess _db;

        public IQueryable<Product> GetProducts()
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM Products";

            return _db.GetData<Product, dynamic>(sqlString, new { });

        }

        public Product GetProductById(int Id)
        {
            _db = new SqlDataAccess();
            string sqlString;
            sqlString = "SELECT * FROM Products WHERE Id = @Id";

            var result =  _db.GetData<Product, dynamic>(sqlString, new {Id = Id });
            return result.FirstOrDefault();

        }

        public int InsertProduct(Product product)
        {
            _db = new SqlDataAccess();
            int productId;
            string sqlString = "INSERT INTO [dbo].[Products] " +
                                       " ([Name] " +
                                       " ,[Description] " +
                                       " ,[Price] " +
                                       " ,[Category] " +
                                       " ,[IsActive]) " +
                                 " VALUES " +
                                       " (@Name " +
                                       " , @Description " +
                                       " , @Price " +
                                       " , @Category " +
                                       " , @IsActive)";

            productId = _db.SaveDataReturnIdentity(sqlString, new {
                product.Name, 
                product.Description, 
                product.Category,
                product.Price,
                product.IsActive });

            return productId;
        }

        public int UpdateProduct(Product product)
        {
            _db = new SqlDataAccess();
            string sqlString = " UPDATE [dbo].[Products] SET Name = @Name," +
                               " Description = @Description, Category  = @Category, " +
                               " Price = @Price WHERE Id = @Id AND IsActive =1";


            var productId = _db.SaveData(sqlString, new
            {
                product.Id,
                product.Name,
                product.Description,
                product.Category,
                product.Price,
                product.IsActive
            });

            return productId;
        }

        public int DeleteProduct(int Id)
        {
            _db = new SqlDataAccess();
            string sqlString = "DELETE FROM [dbo].[Products] WHERE Id = @Id";

            var result = _db.SaveData(sqlString, new { Id });

            return result;
        }
    }
}
