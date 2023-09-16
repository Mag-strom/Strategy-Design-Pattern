using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellStrategy
{
    // Define a class called TravelPlanner
    public class TravelPlanner
    {
        // Private field to store the selected travel strategy
        private ITravelStrategy _travelStrategy;

        // Method to set the travel strategy for the TravelPlanner
        public void SetTravelStartegy(ITravelStrategy travelStrategy)
        {
            // Set the private field _travelStrategy to the provided travel strategy
            _travelStrategy = travelStrategy;
        }
        // Method to calculate the cost of driving a certain number of kilometers
        public string? Drive(int Kilometers)
        {
            // Call the Drive method of the selected travel strategy to calculate the cost
            decimal cost = _travelStrategy.Drive(Kilometers);
            // Return a string that includes the cost and the name of the vehicle
            return $"cost of drive {_travelStrategy.VehicleName} : {cost}";
        }
    }
}
