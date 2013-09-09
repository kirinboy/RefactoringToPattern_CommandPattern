using System.Collections.Generic;

namespace CommandPattern
{
    public class RemoteControl
    {
        private readonly Dictionary<int, ICommand> onCommands = new Dictionary<int, ICommand>();
        private readonly Dictionary<int, ICommand> offCommands = new Dictionary<int, ICommand>();

        public void On(int slot)
        {
            onCommands[slot].Execute();
        }

        public void Off(int slot)
        {
            offCommands[slot].Execute();
        }

        public void SetOnCommand(int slot, ICommand command)
        {
            onCommands.Add(slot, command);
        }

        public void SetOffCommand(int slot, ICommand command)
        {
            offCommands.Add(slot, command);
        }
    }
}