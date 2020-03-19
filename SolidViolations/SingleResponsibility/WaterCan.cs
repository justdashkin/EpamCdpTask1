using System;
using System.Collections.Generic;
using System.Text;

namespace SolidViolations.SingleResponsibility
{
    public class WaterCan
    {
        private int _amountOfWater;

        public void Pour(int amountOfWater)
        {
            _amountOfWater -= amountOfWater;
        }
    }
}
