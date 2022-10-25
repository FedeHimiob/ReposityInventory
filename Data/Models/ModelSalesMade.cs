using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public  class ModelSalesMade
    {
        public int Id { get; set; }

        public int IdClient { get; set; }

        public string InVoice { get; set; }       

        public DateTime SaleDate { get; set; }

        public string Name { get; set; }

        public decimal Monto { get; set; }

        //    public bool PuerchaseType { get; set; }

        //    public bool PaymentStatus { get; set; }
    }
}
