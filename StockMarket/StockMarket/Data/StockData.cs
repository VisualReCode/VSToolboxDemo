using System.Collections.Generic;
using System.Linq;

namespace StockMarket.Data
{
    public class StockData
    {
        private static readonly Item[] Data =
        {
            new Item{ Code = "MSFT", Description = "Microsoft" },
            new Item{ Code = "NFLX", Description = "Netflix"},
            new Item{ Code = "INTC", Description = "Intel"},
            new Item{ Code = "GME", Description = "GameStop"},
        };

        public IEnumerable<Item> GetAll() => Data.AsEnumerable();
    }
}