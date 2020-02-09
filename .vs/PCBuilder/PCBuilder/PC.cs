using System;
using System.Collections.Generic;
using System.Text;
using PCBuilder.Models;

namespace PCBuilder {
    class PC {
        public Component[] Components { get; set; } = new Component[10];

        Type[] necessaryComponentsTypes = {
            typeof(CPU),
            typeof(RAM),
            typeof(PowerSupply),
        };
        public Type[] NecessaryComponentsTypes { get { return necessaryComponentsTypes; } private set { } }


        private bool CanAddComponent(Component component) {
            Type componentType = component.GetType();

            bool componentTypeNecessary = false;
            foreach (Type varType in NecessaryComponentsTypes) {
                if (componentType == varType) { componentTypeNecessary = true; }
            }

            if (componentTypeNecessary) {
                if (this.Components != null) {
                    foreach (Component name in this.Components) {
                        if (name.GetType() == componentType) { return false; }
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// This method adds component to PC
        /// </summary>
        /// <param name="component">Component to be added</param>
        public void AddComponent(Component component) {
            if (this.CanAddComponent(component)) {
                foreach (Component name in this.Components) {
                    if (name == null) {
                        int index = Array.IndexOf(this.Components, name);
                        this.Components[index] = component;
                    }
                }
            }
        }

        public bool HasRequiredComponents() {
            bool hasAllRequired = false;
            foreach (Type type in this.NecessaryComponentsTypes) {
                foreach (Component name in this.Components) {
                    if (name.GetType() == type) { hasAllRequired = true; }
                }
                if (!hasAllRequired) { return false; }
            }
            return true;
        }

        public bool HasPositivePowerBalance() {
            int powerBalance = 0;

            foreach (Component name in this.Components) {
                powerBalance += name.Power;
            }

            return powerBalance >= 0;
        }

        public bool HasNegativeTemperatureBalance() {
            return false;
        }
    }
}
