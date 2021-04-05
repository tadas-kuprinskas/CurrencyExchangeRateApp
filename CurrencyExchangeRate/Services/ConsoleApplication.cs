using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Services
{
    public class ConsoleApplication
    {
        private readonly CalculationService _calculationService;
        private readonly FileService _fileService;
        private readonly ParseService _parseService;

        public ConsoleApplication(CalculationService calculationService, FileService fileService, ParseService parseService)
        {
            _calculationService = calculationService;
            _fileService = fileService;
            _parseService = parseService;
        }
    }
}
