using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EnumInv
{
    public class EnumInv
    {

        public enum OperationProducts 
        {
            Insert = 0,
            Edit = 1
        }
        public enum OperationEntryOrExit
        {
            Entry = 0,
            Exit = 1
        }
        public enum OperationCashOrCredit
        {
            Cash = 0,
            Credit = 1
        }

    }
}
