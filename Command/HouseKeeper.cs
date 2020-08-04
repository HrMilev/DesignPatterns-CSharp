using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class HouseKeeper
    {
        private Dictionary<HouseKeeperCommandsEnum, ICommand> startCommands;
        private Dictionary<HouseKeeperCommandsEnum, ICommand> finishCommands;

        public HouseKeeper()
        {
            startCommands = new Dictionary<HouseKeeperCommandsEnum, ICommand>();
            finishCommands = new Dictionary<HouseKeeperCommandsEnum, ICommand>();
        }

        public void SetCommand(HouseKeeperCommandsEnum commandsEnum, ICommand startCommand, ICommand finishCommand)
        {
            startCommands.Add(commandsEnum, startCommand);
            finishCommands.Add(commandsEnum, finishCommand);
        }

        public string Start(HouseKeeperCommandsEnum commandsEnum)
        {
            return startCommands[commandsEnum].Execute();
        }

        public string Finish(HouseKeeperCommandsEnum commandsEnum)
        {
            return finishCommands[commandsEnum].Execute();
        }
    }
}
