using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class VacuumCleanerOnCommand : ICommand
    {
        private readonly VacuumCleaner vacuumCleaner;

        public VacuumCleanerOnCommand(VacuumCleaner vacuumCleaner)
        {
            this.vacuumCleaner = vacuumCleaner;
        }

        public string Execute()
        {
            return vacuumCleaner.PlugIn()
                + Environment.NewLine
                + vacuumCleaner.Clean();
        }
    }
}
