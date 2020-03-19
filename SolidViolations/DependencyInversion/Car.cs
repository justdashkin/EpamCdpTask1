using System;
using System.Collections.Generic;
using System.Text;

namespace SolidViolations.DependencyInversion
{
    public class Car
    {
        public void DriveTo(string location)
        {
            Console.WriteLine($"Driving to the location: {location} on a car");
        }
    }
}
