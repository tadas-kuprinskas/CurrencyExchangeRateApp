using CurrencyExchangeRate.AppRunner.Helpers;
using CurrencyExchangeRate.AppRunner.Interfaces;
using CurrencyExchangeRate.AppRunner.Services;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CurrencyExchangeRate.App.Tests
{
    public class ValidationServiceTest
    {
        [Theory]
        [InlineData("SEQ/NOK", "8")]
        public void Validate_GivenIncorrectIso_ValidationThrowsArgumentException(string inputIsos, string amount)
        {
            var printMessage = new Mock<IPrint>();
            var exchangeRates = new Mock<IFileService>();
            var validationService = new ValidationService(exchangeRates.Object.GetExchangeRatesFromFile());
            var inputArray = new string[2] { inputIsos, amount };
        
            Action act = () => validationService.Validate(inputArray);

            ArgumentException exception = Assert.Throws<ArgumentException>(act);           
        }

        [Theory]
        [InlineData("SEK/NOK", "k")]
        public void Validate_GivenNotANumber_ValidationThrowsCorrectExceptionWithMessage(string inputIsos, string amount)
        {
            var printMessage = new Mock<IPrint>();
            var exchangeRates = new Mock<IFileService>();
            var validationService = new ValidationService(exchangeRates.Object.GetExchangeRatesFromFile());
            var inputArray = new string[2] { inputIsos, amount };

            Action act = () => validationService.Validate(inputArray);

            act.Should().ThrowExactly<ArgumentException>().WithMessage("There is no such number.");
        }
    }
}
