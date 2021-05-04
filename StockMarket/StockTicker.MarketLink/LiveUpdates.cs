using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockTicker.MarketLink
{
    public class LiveUpdates
    {
        private readonly Random _random = new Random(42);
        private readonly object _mutex = new object();
        private readonly List<string> _watching = new List<string>();
        private CancellationTokenSource _cancellationTokenSource;

        public void Watch(string code)
        {
            lock (_mutex)
            {
                if (!_watching.Contains(code))
                {
                    _watching.Add(code);
                }

                if (_cancellationTokenSource is null)
                {
                    _cancellationTokenSource = new CancellationTokenSource();
                    Task.Run(() => Run(_cancellationTokenSource.Token));
                }
            }
        }

        public void Unwatch(string code)
        {
            lock (_mutex)
            {
                if (!_watching.Contains(code))
                {
                    _watching.Remove(code);
                    if (_watching.Count == 0)
                    {
                        _cancellationTokenSource.Cancel(false);
                        _cancellationTokenSource.Dispose();
                        _cancellationTokenSource = null;
                    }
                }
            }
        }

        private async Task Run(CancellationToken token)
        {
            try
            {
                while (!token.IsCancellationRequested)
                {
                    await Task.Delay(TimeSpan.FromSeconds(1), token);
                    if (_watching.Count == 0) continue;
                    int index = _random.Next(_watching.Count);
                    Updated?.Invoke(_watching[index], Convert.ToDecimal(_random.NextDouble() * 5d), DateTimeOffset.UtcNow);
                }
            }
            catch (OperationCanceledException)
            {
                // Ignore
            }
        }

        public event Action<string, decimal, DateTimeOffset> Updated;
    }
}