using System;
using System.Collections.Generic;
using System.Linq;
using StockMarket.Data;

namespace StockMarket
{
    public class StockInfoService : IStockInfoService
    {
        public IEnumerable<StockItem> GetStocks()
        {
            var data = new StockData();
            return data.GetAll().Select(d => new StockItem
            {
                Code = d.Code,
                Description = d.Description,
            });
        }

        public decimal GetPrice(string code, DateTimeOffset time)
        {
            var data = new StockPriceData();
            return data.GetPrice(code, time);
        }
    }
}
