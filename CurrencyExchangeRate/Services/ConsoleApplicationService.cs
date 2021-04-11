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
        private readonly ValidationService _validationService;

        public ConsoleApplicationService(ICalculationService calculationService, IFileService fileService,
            IUserInputService userInputService, IPrint printService)
        {
            var exchangeRates = fileService.GetExchangeRatesFromFile();
            _parseService = new ParseService(exchangeRates);
            _calculationService = calculationService;
            _userInputService = userInputService;
            _printService = printService;
            _validationService = new ValidationService(exchangeRates);
        }

        public void Run()
        {
            try
            {             
                _printService.PrintMessage($"{Message.usageMessage}\n{Message.startMessage} ");
                var input = _userInputService.GetUserInputArray();
                _validationService.Validate(input);
                var parseExchangeInput = _parseService.ParseExchangeInput(input);
                var result = _calculationService.CalculateExchangeAmount(parseExchangeInput).ToString();
                _printService.PrintMessage(result);
            }
            catch (Exception ex)
            {

                _printService.PrintMessage(ex.Message);
            }
        }
    }
}
