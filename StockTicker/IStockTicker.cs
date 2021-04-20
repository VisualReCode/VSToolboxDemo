using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StockTicker
{
    [ServiceContract(Namespace = "http://recode.samplex.duplex", SessionMode = SessionMode.Required, CallbackContract = typeof(IStockTickerCallback))]
    public interface IStockTicker
    {
        [OperationContract(IsOneWay = true)]
        void Watch(string code);

        [OperationContract(IsOneWay = true)]
        void Unwatch(string code);
    }


    [DataContract]
    public class StockPriceUpdate
    {
        [DataMember] public string Code { get; set; }
        [DataMember] public decimal Price { get; set; }
        [DataMember] public DateTimeOffset Time { get; set; }
    }

    [ServiceContract]
    public interface IStockTickerCallback
    {
        [OperationContract(IsOneWay = true)]
        void Update(StockPriceUpdate update);
    }
}
