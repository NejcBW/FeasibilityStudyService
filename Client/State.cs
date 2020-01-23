using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherGen;

namespace Client
{
    // This class is a global placeholder for the EPW
    // object so that the latter can be shared between
    // different app pages
    public class State
    {
        // the placeholder for the EPW object
        public EPW EPW { get; set; }

        // is set to true when the user loads an EPW
        // file by clicking the load button
        public bool EPWLoaded { get; set; } = false;

        // public default constructor
        // used just to write a console check
        public State()
        {
            Console.WriteLine("Constructing state");
        }

    }
}
