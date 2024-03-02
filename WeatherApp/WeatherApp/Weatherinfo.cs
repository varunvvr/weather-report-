using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    internal class Weatherinfo
    {
        public class WeatherInfo
        {
            public MainInfo main { get; set; }
            public List<WeatherDescription> weather { get; set; }
            public SysInfo sys { get; set; }
            public RainInfo rain { get; set; }
            public SnowInfo snow { get; set; }
            public long timezone { get; set; }
        }

        public class MainInfo
        {
            public double temp { get; set; }
            public int humidity { get; set; }
        }

        public class WeatherDescription
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class SysInfo
        {
            public long sunrise { get; set; }
            public long sunset { get; set; }
        }

        public class RainInfo
        {
            public double rain_1h { get; set; }
        }

        public class SnowInfo
        {
            public double snow_1h { get; set; }
        }

        public static DateTime UnixTimeStampToDateTime(long unixTimeStamp, long timezoneOffset)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp + timezoneOffset);
            return dateTime;
        }
    }
}
