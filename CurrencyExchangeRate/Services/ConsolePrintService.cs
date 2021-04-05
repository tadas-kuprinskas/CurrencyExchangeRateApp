using CurrencyExchangeRate.AppRunner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Services
{
    public class ConsolePrintService : IPrint
    {
        public void PrintMessage(string message)
        {
            Console.Write(message);
        }
    }
}
