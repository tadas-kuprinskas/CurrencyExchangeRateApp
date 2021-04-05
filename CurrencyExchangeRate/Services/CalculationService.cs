using CurrencyExchangeRate.AppRunner.Interfaces;
using CurrencyExchangeRate.AppRunner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Services
{
    public class CalculationService : ICalculationService
    {
        public decimal CalculateExchangeAmount(ExchangeInput input)
        {
            var calculatedResult = input.CurrencyExchangeFrom.Amount / input.CurrencyExchangeTo.Amount
                * input.Amount;

            return calculatedResult;
        }
    }
}
