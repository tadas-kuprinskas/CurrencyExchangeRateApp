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
            var splitArrayIsos = input[0].Split('/');
            var isoExchangeFrom = splitArrayIsos[0].ToUpper();
            var isoExchangeTo = splitArrayIsos[1].ToUpper();
            var currencyExchangeFrom = _exchangeRates.Where(c => c.ISO == isoExchangeFrom).FirstOrDefault();           
            var currencyExchangeTo = _exchangeRates.Where(c => c.ISO == isoExchangeTo).FirstOrDefault();

            return new ExchangeInput()
            {
                CurrencyExchangeFrom = currencyExchangeFrom,
                CurrencyExchangeTo = currencyExchangeTo,
                Amount = amount
            };
        }
    }
}
