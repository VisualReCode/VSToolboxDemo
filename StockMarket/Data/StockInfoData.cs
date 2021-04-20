using System.Collections.Generic;
using System.Linq;

namespace StockMarket.Data
{
    public class StockInfoData
    {
        private static readonly StockInfo[] Data =
        {
            new StockInfo{ Code = "MSFT", Name = "Microsoft" },
            new StockInfo{ Code = "NFLX", Name = "Netflix"},
            new StockInfo{ Code = "INTC", Name = "Intel"},
            new StockInfo{ Code = "GME", Name = "GameStop"},
        };

        public IEnumerable<StockInfo> GetAll() => Data.AsEnumerable();
    }
}