using CurrencyExchangeRate.AppRunner.Helpers;
using CurrencyExchangeRate.AppRunner.Interfaces;
using CurrencyExchangeRate.AppRunner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Services
{
    public class ValidationService
    {        
        private readonly IEnumerable<ExchangeRate> _exchangeRates;       

        public ValidationService(IEnumerable<ExchangeRate> exchangeRates)
        {            
            _exchangeRates = exchangeRates;           
        }

        public void Validate(string[] input)
        {
            try
            {
                var isos = input[0].Split('/');
                var currencyExchangeFrom = isos[0].ToUpper();
                var currencyExchangeTo = isos[1].ToUpper();

                if (int.TryParse(input[1], out int result) == false)
                {
                    throw new ArgumentException(Message.invalidAmountMessage);
                }
                else if (input.Length != 2 || isos.Length != 2)
                {
                    throw new ArgumentException(Message.invalidInput);
                }
                else if (!_exchangeRates.Select(e => e.ISO).Contains(currencyExchangeFrom) ||
                    !_exchangeRates.Select(e => e.ISO).Contains(currencyExchangeTo))
                {
                    throw new ArgumentException(Message.invalidCurrencyMessage);
                }
            }
            catch (ArgumentException ex)
            {               
                    throw new ArgumentException(ex.Message); 
            }
            catch (Exception)
            {
                throw new Exception(Message.invalidInput);
            }
        }
    }
}
