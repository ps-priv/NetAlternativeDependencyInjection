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
    [Register(typeof(StrongInjectServiceProvider))]
    [Register(typeof(WeatherService), Scope.SingleInstance, typeof(IWeatherService))]
    [Register(typeof(TimeService2), Scope.InstancePerDependency, typeof(ITimeService))]
    public partial class StrongInjectContainer : IContainer<StrongInjectServiceProvider>
    {
    }
}
