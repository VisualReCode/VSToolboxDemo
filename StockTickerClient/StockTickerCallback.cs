using System;
using StockTickerConsole.StockTickerService;

namespace StockTickerConsole
{
    public class StockTickerCallback : IStockTickerCallback
    {
        public void Update(StockPriceUpdate update)
        {
            Console.WriteLine($"{update.Code}: {update.Price} at {update.Time:G}");
        }
    }
}