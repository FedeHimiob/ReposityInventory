using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Sale
    {
        public int Id { get; set; }

        public int IdClient { get; set; }

        public string InVoice { get; set; }

        public string Comment { get; set; }

        public DateTime SaleDate { get; set; }

        public bool PuerchaseType { get; set; }

        public bool PaymentStatus { get; set; }

        //public string CustomerName { get; set; } 

    }
}
