using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus03d
{
    class StockItemException : Exception
    {
        public StockItemException(string message) : base(message)
        {
        }
    }
}
