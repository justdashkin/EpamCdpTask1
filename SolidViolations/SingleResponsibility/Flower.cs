using System;
using System.Runtime.InteropServices;

namespace SolidViolations.SingleResponsibility
{
    //It is better to have separate WateringService for this

    public class Flower
    {
        private int _size;
        private bool _isBlooming = false;
        private int _requiredDegreeOfMoisture;
        private int _degreeOfMoisture = 0;

        public void AddDegreeOfMoisture(int amountOfWater)
        {
            _degreeOfMoisture += amountOfWater;
        }

        public void Grow()
        {
            if (_degreeOfMoisture == _requiredDegreeOfMoisture)
                _size++;
        }

        public void Bloom()
        {
            _isBlooming = true;
        }

        public void Water(WaterCan waterCan, int amountOfWater)
        {
            waterCan.Pour(amountOfWater);
            AddDegreeOfMoisture(amountOfWater);
        }
    }
}
