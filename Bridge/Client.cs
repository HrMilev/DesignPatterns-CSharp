using System;

namespace Bridge
{
    public class Client
    {
        public static void Main()
        {
            //Before changes of the business logic
            IDropDownElement element = new TextElement();
            DropDown dropDown = new ConcreteDropDown(new TextElement());
            Console.WriteLine(dropDown.Render());

            //Changes are - add some functionality to DropDowns and unrelated functionality to Elements
            Console.WriteLine(element.ShowInfo());
            Console.WriteLine(dropDown.BeingPretty());
        }
    }
}
