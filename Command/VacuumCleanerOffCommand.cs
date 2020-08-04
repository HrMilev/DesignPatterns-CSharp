using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class VacuumCleanerOffCommand : ICommand
    {
        private readonly VacuumCleaner vacuumCleaner;

        public VacuumCleanerOffCommand(VacuumCleaner vacuumCleaner)
        {
            this.vacuumCleaner = vacuumCleaner;
        }

        public string Execute()
        {
            return vacuumCleaner.Finish();
        }
    }
}
