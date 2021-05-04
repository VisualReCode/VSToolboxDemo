using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using StockTicker.MarketLink;

namespace StockTicker
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class StockTicker : IStockTicker
    {
        private readonly object _mutex = new object();

        private LiveUpdates _liveUpdates;
        private IStockTickerCallback _callback;

        public void Watch(string code)
        {
            lock (_mutex)
            {
                var callback = OperationContext.Current?.GetCallbackChannel<IStockTickerCallback>();
                if (callback is null)
                {
                    throw new Exception("Can't create callback");
                }

                if (_liveUpdates is null)
                {
                    _liveUpdates = new LiveUpdates();
                    _liveUpdates.Updated += (c, p, t) =>
                    {
                        callback.Update(new StockPriceUpdate
                        {
                            Code = c,
                            Price = p,
                            Time = t
                        });
                    };
                }
                _liveUpdates.Watch(code);
            }
        }

        public void Unwatch(string code)
        {
            lock (_mutex)
            {
                if (!(_liveUpdates is null))
                {
                    _liveUpdates.Unwatch(code);
                }
            }
        }
    }
}
