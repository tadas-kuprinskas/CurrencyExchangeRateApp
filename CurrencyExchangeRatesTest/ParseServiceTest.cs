using CurrencyExchangeRate.AppRunner.Models;
using CurrencyExchangeRate.AppRunner.Services;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CurrencyExchangeRatesTest
{
    public class ParseServiceTest
    {
       
        [Theory]
        [InlineData("EUR/DKK", "8")]
        [InlineData("USD/NOK", "4")]
        [InlineData("SEK/USD", "7")]
        public void ParseInput_GivenBothInputs_ReturnSuccessfulParse(string currencyPair, string amount)
        {
            var exchangeRate = new List<ExchangeRate>();
            var parseService = new ParseService(exchangeRate);
            string[] inputArray = { currencyPair, amount };
            var currencyFrom = inputArray[0].Split('/').FirstOrDefault();
            var currencyTo = inputArray[0].Split('/').Last();
            var parsedExchangeInput = parseService.ParseExchangeInput(inputArray);

            parsedExchangeInput.Amount.Should().Be(int.Parse(amount));
            parsedExchangeInput.CurrencyExchangeFrom.Should().Be(currencyFrom);
            parsedExchangeInput.CurrencyExchangeTo.Should().Be(currencyTo);
        }
    }
}
