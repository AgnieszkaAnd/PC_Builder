using System;
using PCBuilder.Models;


namespace PCBuilder {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Build your PC today");

            // User gets into the shop
            User user = new User();

            // User wants to buy a computer
            CPU cpu = new CPU();
            RAM ram = new RAM();
            PowerSupply powerSupply = new PowerSupply();

            PC newlyCreatedPC = new PC();
            newlyCreatedPC.AddComponent(cpu);
            newlyCreatedPC.AddComponent(ram);


            if (!(newlyCreatedPC.HasRequiredComponents() &&
                newlyCreatedPC.HasPositivePowerBalance() &&
                newlyCreatedPC.HasNegativeTemperatureBalance()))
            {
                Console.WriteLine("PC not working, we are not selling it!");
                //throw new PCNotWorkingException();
            }

            newlyCreatedPC.AddComponent(powerSupply);

            // User pays for the computer
            user.AddPC(newlyCreatedPC);
            Console.WriteLine("Congrats! You bought your first computer!");
        }
    }
}
