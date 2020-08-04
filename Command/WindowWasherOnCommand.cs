using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class WindowWasherOnCommand : ICommand
    {
        private readonly WindowWasher windowWasher;

        public WindowWasherOnCommand(WindowWasher windowWasher)
        {
            this.windowWasher = windowWasher;
        }

        public string Execute()
        {
            return windowWasher.Begin();
        }
    }
}
