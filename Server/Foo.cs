using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server
{
    public class Foo : IFoo
    {
        public Foo()
        {
            var rand = new Random();
            var randInt = rand.Next(0, 100);
            RandInt = randInt;
            _instanceId += 1;
            Console.WriteLine($"Foo instance {_instanceId} being constructed");
        }

        public int RandInt { get; set; }
        private static int _instanceId = 0;
    }
}
