using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class ConcreteDropDown : DropDown
    {
        public ConcreteDropDown(IDropDownElement dropDownElement) : base(dropDownElement)
        {

        }

        public override string BeingPretty()
        {
            return "Very nice drop down component";
        }
    }
}
