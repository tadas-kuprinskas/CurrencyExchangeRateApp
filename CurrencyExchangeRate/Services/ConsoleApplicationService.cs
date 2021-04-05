using CurrencyExchangeRate.AppRunner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Services
{
    public class ConsoleApplicationService
    {
        private readonly ICalculationService _calculationService;       
        private readonly IParseService _parseService;       
        
        public ConsoleApplicationService(ICalculationService calculationService, IFileService fileService)
        {
            var currencies = fileService.GetExchangeRatesFromFile();
            _parseService = new ParseService(currencies);           
            _calculationService = calculationService;          
        }

        public string Run(string[] input)
        {
            var parseExchangeInput = _parseService.ParseExchangeInput(input);
            return _calculationService.CalculateExchangeAmount(parseExchangeInput).ToString();
        }
    }
}
