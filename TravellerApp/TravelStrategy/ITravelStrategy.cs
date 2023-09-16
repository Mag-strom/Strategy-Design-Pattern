
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellStrategy
{
    // Define an interface called ITravelStrategy
    public interface ITravelStrategy
    {   // Property to get or set the cost per kilometer
        int KilometerCost { get; set; }
        // Property to get or set the name of the vehicle
        string VehicleName { get; set; }
        // Method to calculate the cost of driving a certain number of kilometers
        decimal Drive(int kilometers); 
    }
}
