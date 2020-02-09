using System;
using System.Collections.Generic;
using System.Text;

namespace PCBuilder
{
    class User
    {
        public List<PC> MyComputers { get; set; } = new List<PC>();

        public void AddPC (PC pc) {
            this.MyComputers.Add(pc);
        }
    }
}
