using CurrencyExchangeRate.AppRunner.Models;

namespace CurrencyExchangeRate.AppRunner.Interfaces
{
    public interface ICalculationService
    {
        decimal CalculateExchangeAmount(ExchangeInput input);
    }
}