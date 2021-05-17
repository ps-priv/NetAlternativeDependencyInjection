using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleDI.Services;
using ConsoleDI.Services.Impl;
using StrongInject;

namespace ConsoleDI.StrongInjectDi
{
    public class StrongInjectServiceProvider
    {
        public IWeatherService WeatherService { get;}
        public ITimeService TimeService { get; }

        public StrongInjectServiceProvider(IWeatherService weatherService, ITimeService timeService)
        {
            WeatherService = weatherService;
            TimeService = timeService;
        }
    }
}
