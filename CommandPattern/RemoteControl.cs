using System.Collections.Generic;

namespace CommandPattern
{
    public class RemoteControl
    {
        private readonly Dictionary<int, ICommand> onCommands = new Dictionary<int, ICommand>();
        private readonly Dictionary<int, ICommand> offCommands = new Dictionary<int, ICommand>();

        public void SetCommand(int slot, ICommand lightOnCommand, ICommand lightOffCommand)
        {
            onCommands.Add(slot, lightOnCommand);
            offCommands.Add(slot, lightOffCommand);
        }

        public void On(int slot)
        {
            onCommands[slot].Execute();
        }

        public void Off(int slot)
        {
            offCommands[slot].Execute();
        }
    }
}