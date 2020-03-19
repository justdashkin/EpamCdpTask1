using System;
using System.Collections.Generic;
using System.Text;

namespace SolidViolations.DependencyInversion
{
    //for example, for now we are delivering only pizzas, driving on a bike
    //what if we decide to deliver pasta also? or to use cars also?
    //We should do IDeliverableFood and ITransport interfaces
    public class FoodDelivery
    {
        private List<Pizza> _foodToBeDelivered;
        private Bike _bike;

        public void Deliver(string location)
        {
            foreach (var pizza in _foodToBeDelivered)
            {
                pizza.Pack();
            }
            _bike.DriveTo(location);
        }
    }
}
