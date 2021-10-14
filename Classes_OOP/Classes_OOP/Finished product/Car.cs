using Classes_OOP.Finished_product.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_OOP.Finished_product
{
    class Car : Vehicle
    {
        public string bodyType { get; set; }

        public Car() : base()
        {
            bodyType = "Not found";
        }
        public Car(Engine _engine, Chassis _chassis, Transmission _transmission, string frameColo, string bodyType):base(_engine, _chassis, _transmission, frameColo)
        {
            this.bodyType = bodyType;
        }
    }
}
