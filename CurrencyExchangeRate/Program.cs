using CurrencyExchangeRate.AppRunner.Interfaces;
using CurrencyExchangeRate.AppRunner.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CurrencyExchangeRate
{
    class Program
    {
        private static IServiceProvider _serviceProvider;

        static void Main(string[] args)
        {
            RegisterServices();           
            IServiceScope scope = _serviceProvider.CreateScope();
            Console.Write("Exchange: ");
            var input = UserInputService.GetUserInputArray();
            var result = scope.ServiceProvider.GetRequiredService<ConsoleApplicationService>().Run(input);
            Console.WriteLine(result);
            DisposeServices();
        }

        private static void RegisterServices()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IFileService, FileService>();
            services.AddSingleton<IParseService, ParseService>();
            services.AddSingleton<ICalculationService, CalculationService>();
            services.AddSingleton<ConsoleApplicationService>();

            _serviceProvider = services.BuildServiceProvider();
        }

        private static void DisposeServices()
        {
            if (_serviceProvider == null)
            {
                return;
            }
            if (_serviceProvider is IDisposable)
            {
                ((IDisposable)_serviceProvider).Dispose();
            }
        }
    }
}
