using System;
using System.Collections.Generic;
using System.Text;

namespace SolidViolations.OpenClosed
{
    public class Coffee: Beverage
    {
        private string _degreeOfRoasting;

        public string GetDegreeOfRoasting()
        {
            return _degreeOfRoasting;
        }

        public void SetDegreeOfRoasting(string degreeOfRoasting)
        {
            _degreeOfRoasting = degreeOfRoasting;
        }

        public override string ToString()
        {
            return "Coffee{" +
                   "degreeOfRoasting='" + _degreeOfRoasting + '\'' +
                   '}';
        }
    }
}
