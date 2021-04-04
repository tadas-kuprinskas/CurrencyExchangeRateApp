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
    public class FileServiceTest
    {
        [Fact]
        public void GetExchangeRatesFromFile_ExchangeRatesFile_FileIsNotEmpty()
        {
            var fileService = new FileService();
            var result = fileService.GetExchangeRatesFromFile();

            result.Should().NotBeEmpty();
        }
    }
}
