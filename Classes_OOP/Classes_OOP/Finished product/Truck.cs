using Classes_OOP.Finished_product.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_OOP.Finished_product
{
    class Truck : Vehicle
    {
        public string bodyType { get; set; }

        public Truck() : base()
        {
            bodyType = "Not found";
        }
        public Truck(Engine _engine, Chassis _chassis, Transmission _transmission, string frameColo, string bodyType) : base(_engine, _chassis, _transmission, frameColo)
        {
            this.bodyType = bodyType;
        }
    }
}
