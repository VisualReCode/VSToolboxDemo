using System.Runtime.Serialization;

namespace StockMarket
{
    [DataContract]
    public class StockInfo
    {
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string Name { get; set; }
    }
}