using CurrencyExchangeRate.AppRunner.Interfaces;
using CurrencyExchangeRate.AppRunner.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeRate.AppRunner.Services
{
    public class FileService : IFileService
    {
        public IEnumerable<ExchangeRate> GetExchangeRatesFromFile()
        {
            using (StreamReader r = new StreamReader("Data\\ExchangeRates.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<IEnumerable<ExchangeRate>>(json);
            }
        }
    }
}
