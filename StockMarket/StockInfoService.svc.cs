using System;
using System.Collections.Generic;
using System.Linq;
using StockMarket.Data;

namespace StockMarket
{
    public class StockInfoService : IStockInfoService
    {
        public IEnumerable<StockInfo> GetStocks()
        {
            var data = new StockData();
            return data.GetAll().Select(d => new StockInfo
            {
                Code = d.Code,
                Name = d.Name,
            });
        }

        public decimal GetPrice(string code, DateTimeOffset time)
        {
            var data = new StockPriceData();
            return data.GetPrice(code, time);
        }
    }
}
