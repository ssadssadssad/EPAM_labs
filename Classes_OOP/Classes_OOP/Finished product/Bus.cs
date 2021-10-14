using Classes_OOP.Finished_product.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_OOP.Finished_product
{
    class Bus: Vehicle
    {
        public int passengersNumber { get; set; }

        public Bus() : base()
        {
            passengersNumber = 0;
        }
        public Bus(Engine _engine, Chassis _chassis, Transmission _transmission, string frameColo, int passengersNumber) : base(_engine, _chassis, _transmission, frameColo)
        {
            this.passengersNumber = passengersNumber;
        }
    }
}
