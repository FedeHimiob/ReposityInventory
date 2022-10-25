using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class ReceivableModel
    {
        public int IdReceivable { get; set; }
        public int IdSale { get; set; }
        public int IdClient { get; set; }
        public string Name { get; set; }
        public string InVoice { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal  PaidAmount { get; set; }
        public int TotalAmount { get; set; }

    }
}
