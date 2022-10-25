using Data.Entities;
using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Servicies
{
    public class ProductsEntryService
    {
        public IEnumerable<ProductsEntry> GetProductsEntry()
        {
            ProductsEntryRepository repo = new ProductsEntryRepository();
            var result = repo.GetProductsEntry().ToList();
            return result;
        }
        public IEnumerable<InventoryModel> GetTotalInventory()
        {
            ProductsEntryRepository repo = new ProductsEntryRepository();
            var result = repo.GetTotalInventory().ToList();
            return result;
        }
        public IEnumerable<HistoricalModel> GetHistoricalProductEntries(int ProductId)
        {
            ProductsEntryRepository repo = new ProductsEntryRepository();
            var result = repo.GetHistoricalProductEntries(ProductId).ToList();
            return result;
        }

        public ProductsEntry GetProductsEntryById(int Id)
        {
            ProductsEntryRepository repo = new ProductsEntryRepository();
            var result = repo.GetProductsEntryById(Id);
            return result;
        }

        public IEnumerable<ProductsEntry> GetProductsEntryByProductId(int ProductId)
        {
            ProductsEntryRepository repo = new ProductsEntryRepository();
            var result = repo.GetProductsEntryByProductId(ProductId).ToList();
            return result;
        }

        public IQueryable<ProductsEntry> GetProductsEntriesByProductId(int ProductId)
        {
            ProductsEntryRepository repo = new ProductsEntryRepository();
            var result = repo.GetProductsEntry();
            result = result.Where(p=> p.ProductId == ProductId);
            return result;
        }

        public int GetProductExistence(int ProductId)
        {
            ProductsEntryRepository repo = new ProductsEntryRepository();
            SaleDetailService service = new SaleDetailService();

            var entries = repo.GetProductsEntry();
            var outforSale = service.GetSaleDetail();

            entries = entries.Where(p => p.ProductId == ProductId );
            var entry = entries.ToList().Where(p=> p.IsEntry==true).Sum(p => p.Quantity);
            var outProduct = entries.ToList().Where(p => p.IsEntry==false).Sum(p => p.Quantity);
            var outProductforSale = outforSale.Where(s => s.ProductId == ProductId).Sum(s => s.Quantity);
            
            var result = (entry - (outProduct+outProductforSale));
            return result;
        }

        public int SaveProductsEntry(ProductsEntry productsEntry)
        {
            ProductsEntryRepository repo = new ProductsEntryRepository();
            ProductsEntry pe = new ProductsEntry();
            int result = 0;

            if (productsEntry.Id > 0)
            {
                pe = repo.GetProductsEntryById(productsEntry.Id);
                if (pe != null)
                {
                    result = repo.UpdateProductsEntry(productsEntry);
                }
            }
            else
            {
                result = repo.InsertProductsEntry(productsEntry);
            }

            return result;
        }

        public int DeleteProductsEntry(int Id)
        {

            ProductsEntryRepository repo = new ProductsEntryRepository();
            int result = 0;

            result = repo.DeleteProductsEntry(Id);
            return result;
        }
    }
}
