using CurrencyExchangeRate.AppRunner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Services
{
    public class ParseService
    {
        private readonly IEnumerable<ExchangeRate> _exchangeRates;

        public ParseService(IEnumerable<ExchangeRate> exchangeRates)
        {
            _exchangeRates = exchangeRates;
        }

        public ExchangeInput ParseExchangeInput(string[] input)
        {
            var amount = int.Parse(input[1]);
            var currencyExchangeFrom = input[0].Split('/').FirstOrDefault();
            var currencyExchangeTo = input[0].Split('/').Last();

            return new ExchangeInput()
            {
                CurrencyExchangeFrom = currencyExchangeFrom,
                CurrencyExchangeTo = currencyExchangeTo,
                Amount = amount
            };
        }
    }
}
