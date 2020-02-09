using System;
using System.Collections.Generic;
using System.Text;

namespace PCBuilder.Models
{
    class PowerSupply : Component
    {
        public enum EnergyClasses {
            Platinum,
            Gold,
            Silver,
            Bronze
        };
        public EnergyClasses EnergyClassPowSupply { get; set; } = EnergyClasses.Platinum;
    }
}
