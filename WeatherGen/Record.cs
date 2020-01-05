using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherGen
{
    public class Record
    {
        public int Id { get; set; }
        //public DateTime Time { get; set; }
        public double DryBulb { get; set; }
        public double DewPoint { get; set; }
        public double RelHum { get; set; }
        public double Pressure { get; set; }
    }
}
