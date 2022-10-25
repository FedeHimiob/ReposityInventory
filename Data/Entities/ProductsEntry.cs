using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{

    //Entrada y Salida de Productos
    public class ProductsEntry
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }       
        public DateTime EntryDate { get; set; }        
        public bool IsEntry { get; set; }

    }
}
