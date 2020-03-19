using System;
using System.Collections.Generic;
using System.Text;

namespace SolidViolations.OpenClosed
{
    public class Tea: Beverage
    {
        private string _type;

        public string GetTeaType()
        {
            return _type;
        }

        public void SetTeaType(string type)
        {
            this._type = type;
        }
        
        public override string ToString()
        {
            return "Tea{" +
                   "type='" + _type + '\'' +
                   '}';
        }
    }
}
