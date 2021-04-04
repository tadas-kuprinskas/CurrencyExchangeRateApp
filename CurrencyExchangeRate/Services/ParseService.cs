using CurrencyExchangeRate.AppRunner.Interfaces;
using CurrencyExchangeRate.AppRunner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Services
{
    public class ParseService : IParseService
    {
        private readonly IEnumerable<ExchangeRate> _exchangeRates;

        public ParseService(IEnumerable<ExchangeRate> exchangeRates)
        {
            _exchangeRates = exchangeRates;
        }

        public ExchangeInput ParseExchangeInput(string[] input)
        {
            var amount = int.Parse(input[1]);
            var fromCurrencyString = input[0].Split('/').FirstOrDefault();
            var currencyExchangeFrom = _exchangeRates.FirstOrDefault(c => c.ISO == fromCurrencyString);
            var toCurrencyString = input[0].Split('/').Last();
            var currencyExchangeTo = _exchangeRates.FirstOrDefault(c => c.ISO == toCurrencyString);

            return new ExchangeInput()
            {
                CurrencyExchangeFrom = currencyExchangeFrom,
                CurrencyExchangeTo = currencyExchangeTo,
                Amount = amount
            };
        }
    }
}
