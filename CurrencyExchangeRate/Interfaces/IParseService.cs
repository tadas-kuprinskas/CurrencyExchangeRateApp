using CurrencyExchangeRate.AppRunner.Models;

namespace CurrencyExchangeRate.AppRunner.Interfaces
{
    public interface IParseService
    {
        ExchangeInput ParseExchangeInput(string[] input);
    }
}