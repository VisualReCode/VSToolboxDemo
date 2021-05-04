using System.Collections.Generic;
using System.Linq;

namespace StockMarket.Data
{
    public class StockInfoData
    {
        private static readonly StockInfo[] Data =
        {
            new StockInfo{ Code = "MSFT", Name = "Microsoft" },
        };

        public IEnumerable<StockInfo> GetAll() => Data.AsEnumerable();
    }
}