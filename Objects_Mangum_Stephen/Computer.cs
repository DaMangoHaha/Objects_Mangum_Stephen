using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Mangum_Stephen
{
    // Represents a computer that can be powered on or off and implements the IBootUp interface
    internal class Computer : IBootUp
    {
        // Indicates whether the computer is currently powered on
        public bool IsOn { get; set; }

        // The brand of the computer (e.g., Apple, Dell)
        public string Brand { get; set; }

        // The type of the computer (e.g., All-in-One, Laptop)
        public string Type { get; set; }

        // Constructor to initialize the computer's brand, type, and power state
        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        // Toggles the power state of the computer and prints a message to the console
        public void PowerOnOff()
        {
            IsOn = !IsOn;

            if (IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else
            {
                Console.WriteLine("The computer is shutting down!");
            }
        }

        // Returns a string that describes the computer's brand, type, and power state
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a {Type} computer, it is {IsOn}";
        }
    }
}
