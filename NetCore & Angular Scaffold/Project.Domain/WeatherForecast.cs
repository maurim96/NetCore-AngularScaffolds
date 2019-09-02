using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Domain
{
    public class WeatherForecast
    {
        private string _dateFormatted;

        public string DateFormatted
        {
            get { return _dateFormatted; }
            set { _dateFormatted = Convert.ToDateTime(value).ToString("d"); }
        }

        public int TemperatureC { get; set; }
        public string Summary { get; set; }

        public int TemperatureF
        {
            get
            {
                return 32 + (int)(TemperatureC / 0.5556);
            }
        }
    }
}
