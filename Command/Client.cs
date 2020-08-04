using System;

namespace Command
{
    public class Client
    {
        public static void Main()
        {
            var vacuumCleaner = new VacuumCleaner();
            var windowWasher = new WindowWasher();

            var startVacuumCleanerCommand = new VacuumCleanerOnCommand(vacuumCleaner);
            var finishVacuumCleanerCommand = new VacuumCleanerOffCommand(vacuumCleaner);
            var startWindowWasherCommand = new WindowWasherOnCommand(windowWasher);
            var finishWindowWasherCommand = new WindowWasherOffCommand(windowWasher);

            var houseKeeper = new HouseKeeper();
            houseKeeper.SetCommand(HouseKeeperCommandsEnum.VacuumCleanerCommand, startVacuumCleanerCommand, finishVacuumCleanerCommand);
            houseKeeper.SetCommand(HouseKeeperCommandsEnum.WindowWasherCommand, startWindowWasherCommand, finishWindowWasherCommand);

            Console.WriteLine(houseKeeper.Start(HouseKeeperCommandsEnum.VacuumCleanerCommand));
            Console.WriteLine(houseKeeper.Finish(HouseKeeperCommandsEnum.VacuumCleanerCommand));
            Console.WriteLine(houseKeeper.Start(HouseKeeperCommandsEnum.WindowWasherCommand));
            Console.WriteLine(houseKeeper.Finish(HouseKeeperCommandsEnum.WindowWasherCommand));
        }
    }
}
