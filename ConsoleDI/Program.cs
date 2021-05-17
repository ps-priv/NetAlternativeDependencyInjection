using System;
using ConsoleDI.JabDi;
using ConsoleDI.Services;
using ConsoleDI.StrongInjectDi;
using Jab;
using StrongInject;

namespace ConsoleDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DI Test");

            #region Jab DI
            Console.WriteLine("Jab");
            var serviceProvider = new JabServiceProvider();
            var service = serviceProvider.GetService<IWeatherService>();

            foreach (var weatherForecast in service.GetForecast())
            {
                Console.WriteLine(weatherForecast.ToString());
            }

            var timeService = serviceProvider.GetService<ITimeService>();
            Console.WriteLine($"Time service ({timeService.GetType().Name}): {timeService.GetCurrentTime()}");
            #endregion

            #region StrongInject DI
            Console.WriteLine("\n\nStrongInject");
            var container = new StrongInjectContainer();
            var serviceSI = container.Resolve().Value.WeatherService;

            foreach (var weatherForecast in serviceSI.GetForecast())
            {
                Console.WriteLine(weatherForecast.ToString());
            }

            var timeServiceSI = container.Resolve().Value.TimeService;
            Console.WriteLine($"Time service ({timeServiceSI.GetType().Name}): {timeServiceSI.GetCurrentTime()}");
            #endregion

            Console.WriteLine("Koniec");
            Console.ReadLine();
        }
    }
}
