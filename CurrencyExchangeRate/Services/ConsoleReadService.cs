using CurrencyExchangeRate.AppRunner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Services
{
    public class ConsoleInputService : IUserInputService
    {
        public string[] GetUserInputArray()
        {
            return Console.ReadLine().Split(" ");                      
        }
    }
}
