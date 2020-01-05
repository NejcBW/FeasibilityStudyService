using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherGen;

namespace Client
{
    public class State
    {
        public EPW EPW { get; set; }

        public bool EPWLoaded { get; set; } = false;

        public State()
        {
            Console.WriteLine("Constructing state");
        }

    }
}
