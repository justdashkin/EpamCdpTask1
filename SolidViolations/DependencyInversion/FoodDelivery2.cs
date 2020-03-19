using System.Collections.Generic;

namespace SolidViolations.DependencyInversion
{
    //this is to illustrate the changes
    public class FoodDelivery2
    {
        private List<Pizza> _foodToBeDelivered;
        private Bike _bike;
        private Car _car;

        public void Deliver(string location)
        {
            foreach (var pizza in _foodToBeDelivered)
            {
                pizza.Pack();
            }
            if(_bike!=null)
                _bike.DriveTo(location);
            else _car.DriveTo(location);
        }
    }
}
