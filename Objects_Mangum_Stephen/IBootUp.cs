using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Mangum_Stephen
{
    // Defines the contract for bootable devices
    internal interface IBootUp
    {
        // Property indicating whether the device is powered on (true) or off (false)
        public bool IsOn { get; set; }

        // Method to toggle the power state of the device
        public void PowerOnOff();
    }
}
