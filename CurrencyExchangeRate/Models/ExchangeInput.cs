using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Models
{
    public class ExchangeInput
    {
        public string CurrencyExchangeFrom { get; set; }
        public string CurrencyExchangeTo { get; set; }
        public int Amount { get; set; }
    }
}
