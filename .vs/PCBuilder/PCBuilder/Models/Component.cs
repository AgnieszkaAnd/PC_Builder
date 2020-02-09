using System;
using System.Collections.Generic;
using System.Text;

namespace PCBuilder.Models
{
    abstract class Component
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int Temperature { get; set; }
        public double Price { get; set; }

        public  Component(string Name, int Power, int Temperature, double Price) {
            this.Name = Name;
            this.Power = Power;
            this.Temperature = Temperature;
            this.Price = Price;
        }
    }
}
