using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Models
{
    public class ExchangeRate
    {
        public string Currency { get; set; }
        public string ISO { get; set; }
        public decimal Amount { get; set; }
    }
}
