using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class InventoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CantidadEntrada { get; set; }
        public int CantidadSalida { get; set; }
        public int CantidadDisponible { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        //Id/Name/CantidadEntrada...
        //pilas con el tipo e dato
        //luego 
    }
}
