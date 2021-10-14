using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_OOP
{
    class Chassis
    {
        public int wheelsNumber { get; set; }
        public string number { get; set; }
        public double permissible_load { get; set; }

        public Chassis():this(0, "Not found", 0d)
        {

        }
        public Chassis(int wheelsNumber, string number, double permissible_load)
        {
            this.wheelsNumber = wheelsNumber;
            this.number = number;
            this.permissible_load = permissible_load;
        }
    }
}
