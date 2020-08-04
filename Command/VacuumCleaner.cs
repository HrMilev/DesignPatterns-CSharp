using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class VacuumCleaner
    {
        public string PlugIn()
        {
            return "Vacuum cleaner was plugged";
        }

        public string Clean()
        {
            return "Cleaning with vacuum cleaner ...";
        }

        public string Finish()
        {
            return "Vacuum cleaner was unplugged";
        }
    }
}
