using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class WindowWasherOffCommand : ICommand
    {
        private readonly WindowWasher windowWasher;

        public WindowWasherOffCommand(WindowWasher windowWasher)
        {
            this.windowWasher = windowWasher;
        }

        public string Execute()
        {
            return windowWasher.End();
        }
    }
}
