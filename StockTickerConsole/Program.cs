using System;
using System.ServiceModel;
using System.Threading.Tasks;

namespace StockTickerConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var context = new InstanceContext(new StockTickerCallback());
            var client = new StockTickerService.StockTickerClient(context, "WSDualHttpBinding_IStockTicker");
            await client.WatchAsync("MSFT");
            await client.WatchAsync("NFLX");

            Console.WriteLine("Press Q to exit...");
            while (Console.ReadKey().Key != ConsoleKey.Q) { }
        }
    }
}
