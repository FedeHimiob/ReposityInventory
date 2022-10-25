using Data.Entities;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Servicies
{
    public class ProductService
    {

        public IQueryable<Product> GetProducts()
        {
            ProductRepository repo = new ProductRepository();
            var result = repo.GetProducts();
            return result;
        }

        public IQueryable<Product> GetProducts(int[] productList)
        {
            ProductRepository repo = new ProductRepository();
            var result = repo.GetProducts().Where(p=> productList.Any(x=> p.Id.Equals(x)));
            return result;
        }

        public Product GetProductById(int Id)
        {
            ProductRepository repo = new ProductRepository();
            var result = repo.GetProductById(Id);
            return result;
        }

        public int SaveProduct(Product product)
        {
            ProductRepository repo = new ProductRepository();
            Product p = new Product();
            int result =0;

            if (product.Id > 0)
            {
                p = repo.GetProductById(product.Id);
                if (p != null)
                {
                    result = repo.UpdateProduct(product);
                }
            }
            else {
                result = repo.InsertProduct(product);
            }

            return result;
        }

        public int DeleteProduct(int Id)
        {

            ProductRepository repo = new ProductRepository();
            int result = 0;           

                result = repo.DeleteProduct(Id);
            return result;
        }
    }
}
