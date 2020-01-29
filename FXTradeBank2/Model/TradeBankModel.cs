using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FXTradeBank2.Model
{
    public class TradeBankModel
    {
        public string Id { get; set; } = "";
        public string SourceCurrency { get; set; } = "";
        public string DestinationCurrency { get; set; } = "";
        public int Amount { get; set; } = 0;
        public string Status { get; set; } = "";
    }
}
