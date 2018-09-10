using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursus03d
{
    class StockItem
    {
        public int Id { get; set; }

        public StockItem(int id)
        {
            this.Id = id;
            if(id < 0)
            {
                throw new StockItemException("Wrong id");
            }
        }
    }
}
