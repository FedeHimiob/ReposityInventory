using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Receivable
    {
        public int Id { get; set; }
        public int SaleId { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }

    }
}
