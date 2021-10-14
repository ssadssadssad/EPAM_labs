using Classes_OOP.Finished_product.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_OOP.Finished_product
{
    class Scooter : Vehicle
    {
        public string frontFork { get; set; }

        public Scooter() : base()
        {
            frontFork = "Not found";
        }
        public Scooter(Engine _engine, Chassis _chassis, Transmission _transmission, string frameColo, string frontFork) : base(_engine, _chassis, _transmission, frameColo)
        {
            this.frontFork = frontFork;
        }
    }
}
