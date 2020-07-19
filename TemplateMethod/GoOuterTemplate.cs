using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    //This class is base for the similar set of algorithms
    //Here we define placeholders for the things that differ  
    //in the set.
    public abstract class GoOuterTemplate
    {
        //This method creates the skeleton of the algorithms.
        public string LetsGo()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"When {this.GetType().Name} is called:");
            stringBuilder.AppendLine(DressUp());
            stringBuilder.AppendLine(GetYourStuff());
            
            stringBuilder.AppendLine("- Go out and have some fun!");
            return stringBuilder.ToString();
        }

        protected abstract string GetYourStuff();

        protected abstract string DressUp();
    }
}
