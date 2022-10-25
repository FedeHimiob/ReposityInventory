using Data.Entities;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Servicies
{
    public class SaleDetailService
    {
        public IEnumerable<SaleDetail> GetSaleDetail()
        {
            SaleDetailRepository repo = new SaleDetailRepository();
            var result = repo.GetSaleDetail().ToList();
            return result;
        }

        public IEnumerable<SaleDetail> GetSaleDetailBySaleId(int SaleId)
        {
            SaleDetailRepository repo = new SaleDetailRepository();
            var result = repo.GetSaleDetailBySaleId(SaleId);
            return result;
        }

        public int SaveSaleDetail(SaleDetail saleDetail)
        {
            SaleDetailRepository repo = new SaleDetailRepository();
            SaleDetail sd = new SaleDetail();
            int result = 0;

            if (saleDetail.Id > 0)
            {
                sd = repo.GetSaleDetailById(saleDetail.Id);
                if (sd != null)
                {
                    result = repo.UpdateSaleDetail(saleDetail);
                }
            }
            else
            {
                result = repo.InsertSaleDetail(saleDetail);
            }

            return result;
        }
    }
}
