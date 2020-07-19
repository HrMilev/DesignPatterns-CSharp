using System;

namespace TemplateMethod
{
    //This class is yet another algorithm from the set
    public class DinnerGoOuter : GoOuterTemplate
    {
        protected override string DressUp()
        {
            return "- Find something other than sweatsuit and dress up";
        }

        protected override string GetYourStuff()
        {
            return "- Prepare some jokes, if you want this dinner to be fun on a bun";
        }
    }
}
