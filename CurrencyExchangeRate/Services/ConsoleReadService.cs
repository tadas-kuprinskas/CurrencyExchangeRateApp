using CurrencyExchangeRate.AppRunner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Services
{
    public class ConsoleReadService : IUserInputService
    {
        public string[] GetUserInputArray()
        {
            return Console.ReadLine().Split(" ");
        }

        public void ReadMessage()
        {
            Console.ReadLine();
        }
    }
}
