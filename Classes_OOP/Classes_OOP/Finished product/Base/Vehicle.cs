using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_OOP.Finished_product.Base
{
    class Vehicle
    {
        public Engine _engine { get; set; }
        public Chassis _chassis { get; set; }
        public Transmission _transmission { get; set; }
        public string frameColor { get; set; }

        public Vehicle() : this(null, null, null, "Not Found")
        {

        }
        public Vehicle(Engine _engine, Chassis _chassis, Transmission _transmission, string frameColor)
        {
            this._engine = _engine;
            this._chassis = _chassis;
            this._transmission = _transmission;
            this.frameColor = frameColor;
        }
    }
}
