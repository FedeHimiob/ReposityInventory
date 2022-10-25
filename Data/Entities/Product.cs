using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public int SubTotal { get ; set; } //agregar a SQL

        public decimal Price { get; set; }
        public bool IsActive { get; set; }

    }
}
