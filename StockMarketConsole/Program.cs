using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockMarketClient.StockMarketService;

namespace StockMarketClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new StockInfoServiceClient("BasicHttpBinding_IStockInfoService");
            var stocks = await client.GetStocksAsync();

            for (var i = 0; i < stocks.Length; i++)
            {
                var stock = stocks[i];
                Console.WriteLine($"[{i+1}] {stock.Code}:\t{stock.Name}");
            }

            Console.WriteLine("[Q] Quit");

            Console.Write("Choose: ");
            var input = Console.ReadLine();
            while (!"q".Equals(input, StringComparison.OrdinalIgnoreCase))
            {
                if (int.TryParse(input, out int index) && index > 0 && index <= stocks.Length)
                {
                    var stock = stocks[index - 1];
                    var now = DateTimeOffset.UtcNow;
                    var price = await client.GetPriceAsync(stock.Code, now);
                    Console.WriteLine();
                    Console.WriteLine($"{stock.Code} = {price} at {now:G}");
                }
                Console.Write("Choose: ");
                input = Console.ReadLine();
            }
        }
    }
}
