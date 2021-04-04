using CurrencyExchangeRate.AppRunner.Models;
using System.Collections.Generic;

namespace CurrencyExchangeRate.AppRunner.Interfaces
{
    public interface IFileService
    {
        IEnumerable<ExchangeRate> GetExchangeRatesFromFile();
    }
}