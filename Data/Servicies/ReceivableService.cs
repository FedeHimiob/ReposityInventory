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
    public class ReceivableService
    {
        public IEnumerable<Receivable> GetReceivable()
        {
            ReceivableRepository repo = new ReceivableRepository();
            var result = repo.GetReceivable().ToList();
            return result;
        }
        public IEnumerable<ReceivableModel> GetReceivableMade()
        {
            ReceivableRepository repo = new ReceivableRepository();
            var result = repo.GetReceivableMade().ToList();
            return result;
        }
        public Receivable GetReceivableId(int Id)
        {
            ReceivableRepository repo = new ReceivableRepository();
            var result = repo.GetReceivableById(Id);
            return result;
        }
        public Receivable GetReceivableSaleId(int SaleId)
        {
            ReceivableRepository repo = new ReceivableRepository();
            var result = repo.GetReceivableBySaleId(SaleId);
            return result;
        }

        public int SaveReceivable(Receivable receivable)
        {
            ReceivableRepository repo = new ReceivableRepository();
            Receivable r = new Receivable();
            int result = 0;

            if (receivable.Id > 0)
            {
                r = repo.GetReceivableById(receivable.Id);
                if (r != null)
                {
                    result = repo.UpdateReceivable(receivable);
                }
            }
            else
            {
                result = repo.InsertReceivable(receivable);
            }

            return result;
        }
    }
}
