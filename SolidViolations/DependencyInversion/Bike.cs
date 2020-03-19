using System;

namespace SolidViolations.DependencyInversion
{
    public class Bike
    {
        public void DriveTo(string location)
        {
            Console.WriteLine($"Driving to the location: {location} on a bike");
        }
    }
}
