using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Services
{
    public static class UserInputService
    {
        public static string[] GetUserInputArray()
        {
            var inputIsos = Console.ReadLine();
            var inputAmount = Console.ReadLine();
            return new string[2] { inputIsos, inputAmount };
        }
    }
}
