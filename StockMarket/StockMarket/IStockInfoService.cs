using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StockMarket
{
    [ServiceContract]
    public interface IStockInfoService
    {

        [OperationContract]
        IEnumerable<StockItem> GetStocks();

        [OperationContract]
        decimal GetPrice(string code, DateTimeOffset time);
    }
}
