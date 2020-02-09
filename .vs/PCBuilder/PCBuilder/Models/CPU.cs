using System;
using System.Collections.Generic;
using System.Text;

namespace PCBuilder.Models {
    class CPU : Component {
        public double Speed { get; set; }
        public int Cache { get; set; }
        public int NumberOfCores { get; set; }

        public CPU(string Name, int Power, int Temperature, double Price) : base(Name, Power, Temperature, Price) { }
    }
}
