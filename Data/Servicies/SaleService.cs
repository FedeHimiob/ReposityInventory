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
    public class SaleService
    {
        public IEnumerable<Sale> GetSale()
        {
            SaleRepository repo = new SaleRepository();
            var result = repo.GetSale().ToList();
            return result;
        }
        public IEnumerable<ModelSalesMade> GetSalesMade()
        {
            SaleRepository repo = new SaleRepository();
            var result = repo.GetSalesMade().ToList();
            return result;
        }


        public Sale GetSaleById(int Id)
        {
            SaleRepository repo = new SaleRepository();
            var result = repo.GetSaleById(Id);
            return result;
        }
        public Sale GetSaleByInVoice(string inVoice)
        {
            SaleRepository repo = new SaleRepository();
            var result = repo.GetSaleByInVoice(inVoice);
            return result;
        }

        public int SaveSale(Sale sale)
        {
            SaleRepository repo = new SaleRepository();
            Sale s = new Sale();
            int result = 0;

            if (sale.Id > 0)
            {
                s = repo.GetSaleById(sale.Id);
                if (s != null)
                {
                    result = repo.UpdateSale(sale);
                }
            }
            else
            {
                result = repo.InsertSale(sale);
            }

            return result;
        }

        public int DeleteSale(int Id)
        {
            SaleRepository repo = new SaleRepository();
            int result = 0;

            result = repo.DeleteSale(Id);
            return result;
        }
    }
}
