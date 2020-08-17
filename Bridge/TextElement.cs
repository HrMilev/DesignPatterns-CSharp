using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class TextElement : IDropDownElement
    {
        public string Render()
        {
            return "Hello from text";
        }

        public string ShowInfo()
        {
            return "Useful info";
        }
    }
}
