using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDI.Services
{
    public interface IWeatherService
    {
        public IEnumerable<WeatherForecast> GetForecast();
    }
}
