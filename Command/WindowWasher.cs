using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class WindowWasher
    {
        public string Begin()
        {
            return "Start washing windows ...";
        }

        public string End()
        {
            return "Finish washing windows";
        }
    }
}
