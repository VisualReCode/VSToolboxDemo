using System;

namespace StockMarket.Data
{
    public class StockPriceData
    {
        public decimal GetPrice(string code, DateTimeOffset time)
        {
            return new Random(GetSeed(code, time)).Next(100, 10000) / 100m;
        }

        private int GetSeed(string code, DateTimeOffset time)
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 31 + code.GetHashCode();
                hash = hash * 31 + time.GetHashCode();
                return hash;
            }
        }
    }
}