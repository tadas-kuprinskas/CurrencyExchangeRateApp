using CurrencyExchangeRate.AppRunner.Models;
using CurrencyExchangeRate.AppRunner.Services;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CurrencyExchangeRate.App.Tests
{
    public class CalculationServiceTest
    {
        [Theory]
        [InlineData("SEK", "NOK", 76.10, 78.40)]
        public void CalculateExchangeAmount_GivenInput_ReturnsCorrectResult(string isoExchangeFrom, string isoExchangeTo, decimal amountFrom, decimal amountTo)
        {
            var fileService = new FileService();
            var exchangeRates = fileService.GetExchangeRatesFromFile();           

            var exchangeInput = new ExchangeInput()
            {
                Amount = 10,
                CurrencyExchangeFrom = exchangeRates.Where(c => c.ISO == isoExchangeFrom).FirstOrDefault(),
                CurrencyExchangeTo = exchangeRates.Where(c => c.ISO == isoExchangeTo).FirstOrDefault()
            };

            var calculationService = new CalculationService();
            var calculatedRate = calculationService.CalculateExchangeAmount(exchangeInput);
            var result = amountFrom / amountTo * exchangeInput.Amount;
            calculatedRate.Should().Be(result);

        }
    }
}
