﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellStrategy.TravellingStrategies
{
    // Define a class called Plane that implements the ITravelStrategy interface
    public class Plane : ITravelStrategy
    {
        // Property to get or set the cost per kilometer
        public int KilometerCost { get; set; }
        // Property to get or set the name of the vehicle
        public string VehicleName { get; set; }
        // Constructor for the plane class
        public Plane()
        {
            KilometerCost = 50;
            VehicleName = "Plane";
        }
        // Method to calculate the cost of driving a certain number of kilometers
        public decimal Drive(int Kilometers)
        {
            // Adjust the KilometerCost based on the number of kilometers traveled
            if (Kilometers < 100)
            {
                KilometerCost *= 2;
            }
            else if (Kilometers >= 100 && Kilometers < 500)
            {
                KilometerCost = (KilometerCost * 2) - (KilometerCost / 2);
            }
            else
            {
                KilometerCost -= 5;
            }
            // Calculate and return the total cost of the trip
            return Kilometers * KilometerCost;
        }
    }
}
