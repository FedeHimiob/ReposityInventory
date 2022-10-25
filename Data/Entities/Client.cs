using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string DocumentIdentity { get; set; }

        public string Phone { get; set; }
    }
}
