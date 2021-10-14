using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_OOP
{
    class Engine
    {
        public double power { get; set; }
        public double volume { get; set; }
        public string type { get; set; }
        public string serialNumber { get; set; }

        public Engine():this(0d, 0d, "Not found", "Not found")
        {

        }
        public Engine(double power, double volume, string type, string serialNumber)
        {
            this.power = power;
            this.volume = volume;
            this.type = type;
            this.serialNumber = serialNumber;
        }
    }
}
