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
        [InlineData("EUR/SEK", "8")]     
        public void ParseExchangeInput_GivenBothInputs_ReturnSuccessfulParse(string currencyPair, string amount)
        {
            var fileService = new FileService();
            var exchangeRates = fileService.GetExchangeRatesFromFile();
            
            var parseService = new ParseService(exchangeRates);
            string[] inputArray = { currencyPair, amount };
            
            var parsedExchangeInput = parseService.ParseExchangeInput(inputArray);

            parsedExchangeInput.Amount.Should().Be(8);
            parsedExchangeInput.CurrencyExchangeFrom.ISO.Should().Be("EUR");
            parsedExchangeInput.CurrencyExchangeTo.ISO.Should().Be("SEK");
        }
    }
}
