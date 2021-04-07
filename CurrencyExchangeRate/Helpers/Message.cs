using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Helpers
{
    public static class Message
    {
        public static string startMessage = "Exchange";
        public static string usageMessage = "Exchange <currency pair> <amount to exchange>";
        public static string invalidCurrencyMessage = "There is no such currency.";
        public static string invalidAmountMessage = "There is no such number.";
        public static string invalidInput = "Invalid input";
    }
}
