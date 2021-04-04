using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Models
{
    public class ExchangeInput
    {
        public ExchangeRate CurrencyExchangeFrom { get; set; }
        public ExchangeRate CurrencyExchangeTo { get; set; }
        public int Amount { get; set; }
    }
}
