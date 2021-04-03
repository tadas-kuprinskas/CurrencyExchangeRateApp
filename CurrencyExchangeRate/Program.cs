using CurrencyExchangeRate.AppRunner.Services;
using System;
using System.Linq;

namespace CurrencyExchangeRate
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileService = new FileService();
            var result = fileService.GetExchangeRatesFromFile();
           
        }
    }
}
