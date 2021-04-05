using CurrencyExchangeRate.AppRunner.Helpers;
using CurrencyExchangeRate.AppRunner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Services
{
    public class ConsoleApplicationService : IConsoleApplicationService
    {
        private readonly ICalculationService _calculationService;
        private readonly IParseService _parseService;
        private readonly IUserInputService _userInputService;
        private readonly IPrint _printService;

        public ConsoleApplicationService(ICalculationService calculationService, IFileService fileService,
            IUserInputService userInputService, IPrint printService)
        {
            var currencies = fileService.GetExchangeRatesFromFile();
            _parseService = new ParseService(currencies);
            _calculationService = calculationService;
            _userInputService = userInputService;
            _printService = printService;
        }

        public void Run()
        {
            _printService.PrintMessage($"{Message.usageMessage}\n{Message.startMessage} ");
            var input = _userInputService.GetUserInputArray();
            var parseExchangeInput = _parseService.ParseExchangeInput(input);
            var result = _calculationService.CalculateExchangeAmount(parseExchangeInput).ToString();
            _printService.PrintMessage(result);
        }
    }
}
