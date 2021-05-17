using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleDI.Services;
using ConsoleDI.Services.Impl;
using Jab;

namespace ConsoleDI.JabDi
{
    [ServiceProvider]
    [Singleton(typeof(IWeatherService), typeof(WeatherService))]
    [Transient(typeof(ITimeService), typeof(TimeService))]
    public partial class JabServiceProvider
    {

    }
}
