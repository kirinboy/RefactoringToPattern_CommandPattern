using System.Collections.Generic;

namespace CommandPattern
{
    public class RemoteControl
    {
        private readonly Dictionary<int, ICommand> onCommands = new Dictionary<int, ICommand>();
        private readonly Dictionary<int, ICommand> offCommands = new Dictionary<int, ICommand>();

        public RemoteControl(Light light, Ceiling ceiling, Stereo stereo)
        {
            offCommands.Add(1, new LightOffCommand(light));
            offCommands.Add(2, new CeilingOffCommand(ceiling));
            offCommands.Add(3, new StereoOffCommand(stereo));
            SetOnCommand(1, new LightOnCommand(light));
            SetOnCommand(2, new CeilingHighCommand(ceiling));
            SetOnCommand(3, new StereoOnCommand(stereo));
        }

        public void On(int slot)
        {
            onCommands[slot].Execute();
        }

        public void Off(int slot)
        {
            offCommands[slot].Execute();
        }

        private void SetOnCommand(int slot, ICommand command)
        {
            onCommands.Add(slot, command);
        }
    }
}