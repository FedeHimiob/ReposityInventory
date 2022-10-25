using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class HistoricalModel
    {
        public int IdProduct { get; set; }

        public int IdEntry { get; set; }

        public DateTime  EntryDate { get; set; }

        public int Entrada { get; set; }

        public int Salida { get; set; }
    }
}
