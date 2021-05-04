using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Data
{
    public class Item
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int Available { get; set; }
        public decimal Price { get; set; }
    }
}
