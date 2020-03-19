using System;
using System.Collections.Generic;

namespace SolidViolations.OpenClosed
{
    //Beverage contains recipes of its subclasses, and that makes it really sensitive to changes
    //For example, if we Juice to our hierarchy, we will need to write one more branch in if clause
    //and specify recipe for it, so for now this class is opened for modifications
    //To avoid this, we need to move recipe logic (mix method) to subclasses

    public abstract class Beverage
    {
        private List<string> _ingredients;

        private void Mix()
        {
            Console.WriteLine("Mixed beverage from following ingredients: " + _ingredients);
        }

        public void Mix(Beverage beverage)
        {
            if (beverage.GetType() == typeof(Coffee)) {
                _ingredients = new List<string>{((Coffee) beverage).GetDegreeOfRoasting()
                                           + " roasted beans", "hot water"};
            } else if (beverage.GetType() == typeof(Tea)) {
                _ingredients = new List<string> { ((Tea)beverage).GetTeaType() + " tea", "hot water" };
            } else
            {
                throw new ArgumentException("Unidentifiable beverage");
            }
            Mix();
        }
    }
}
