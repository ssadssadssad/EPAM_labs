using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_OOP
{
    class Transmission
    {
        public string type { get; set; }
        public int gearsNumber { get; set; }
        public string producer { get; set; }

        public Transmission():this("Not found", 0 , "Not Found")
        {

        }
        public Transmission(string type, int gearsNumber, string producer)
        {
            this.type = type;
            this.gearsNumber = gearsNumber;
            this.producer = producer;
        }
    }
}
