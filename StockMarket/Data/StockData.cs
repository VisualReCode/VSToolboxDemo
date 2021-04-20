using System.Collections.Generic;
using System.Linq;

namespace StockMarket.Data
{
    public class StockData
    {
        private static readonly Stock[] Data =
        {
            new Stock{ Code = "MSFT", Name = "Microsoft" },
            new Stock{ Code = "NFLX", Name = "Netflix"},
            new Stock{ Code = "INTC", Name = "Intel"},
            new Stock{ Code = "GME", Name = "GameStop"},
        };

        public IEnumerable<Stock> GetAll() => Data.AsEnumerable();
    }
}