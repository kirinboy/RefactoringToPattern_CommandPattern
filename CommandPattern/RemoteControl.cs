using System.Collections.Generic;

namespace CommandPattern
{
    public class RemoteControl
    {
        private readonly Light light;
        private readonly Ceiling ceiling;
        private readonly Stereo stereo;
        private readonly Dictionary<int, ICommand> getOffCommands;
        private readonly Dictionary<int, ICommand> getOnCommands;
        private readonly Dictionary<int, ICommand> onCommands = new Dictionary<int, ICommand>();
        private readonly Dictionary<int, ICommand> offCommands = new Dictionary<int, ICommand>();

        public RemoteControl(Light light, Ceiling ceiling, Stereo stereo)
        {
            this.light = light;
            this.ceiling = ceiling;
            this.stereo = stereo;
            getOffCommands = GetOffCommands();
            getOnCommands = GetOnCommands();
        }

        public void On(int slot)
        {
            getOnCommands[slot].Execute();
        }

        public void Off(int slot)
        {
            getOffCommands[slot].Execute();
        }

        private Dictionary<int, ICommand> GetOnCommands()
        {
            SetOnCommand(1, new LightOnCommand(light));
            SetOnCommand(2, new CeilingHighCommand(ceiling));
            SetOnCommand(3, new StereoOnCommand(stereo));
            return onCommands;
        }

        private void SetOnCommand(int slot, ICommand command)
        {
            onCommands.Add(slot, command);
        }

        private Dictionary<int, ICommand> GetOffCommands()
        {
            SetOffCommand(1, new LightOffCommand(light));
            SetOffCommand(2, new CeilingOffCommand(ceiling));
            SetOffCommand(3, new StereoOffCommand(stereo));
            return offCommands;
        }

        private void SetOffCommand(int slot, ICommand command)
        {
            offCommands.Add(slot, command);
        }
    }
}