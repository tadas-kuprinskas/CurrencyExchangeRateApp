using CurrencyExchangeRate.AppRunner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Services
{
    public class CalculationService
    {
        private readonly FileService _fileService;

        public CalculationService(FileService fileService)
        {
            _fileService = fileService;
        }

        //public decimal CalculateExchangeAmount(ExchangeInput input)
        //{
            
        //}
    }
}
