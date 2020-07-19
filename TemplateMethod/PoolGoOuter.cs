using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    //This class gives the concrete implementations of the placeholders
    //needed for its particular use case 
    public class PoolGoOuter : GoOuterTemplate
    {
        protected override string DressUp()
        {
            return "- Get your swinsuit and try to fit into it";
        }

        protected override string GetYourStuff()
        {
            return "- Pick up some life jacket, just in case";
        }
    }
}
