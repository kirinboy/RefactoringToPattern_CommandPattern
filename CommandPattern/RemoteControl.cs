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
            var onCommands = new Dictionary<int, ICommand>();
            var lightOnCommand = new LightOnCommand(light);
            var ceilingHighCommand = new CeilingHighCommand(ceiling);
            var stereoOnCommand = new StereoOnCommand(stereo);
            onCommands.Add(1, lightOnCommand);
            onCommands.Add(2, ceilingHighCommand);
            onCommands.Add(3, stereoOnCommand);
            return onCommands;
        }

        private Dictionary<int, ICommand> GetOffCommands()
        {
            var offCommands = new Dictionary<int, ICommand>();
            var lightOffCommand = new LightOffCommand(light);
            var ceilingOffCommand = new CeilingOffCommand(ceiling);
            var stereoOffCommand = new StereoOffCommand(stereo);
            offCommands.Add(1, lightOffCommand);
            offCommands.Add(2, ceilingOffCommand);
            offCommands.Add(3, stereoOffCommand);
            return offCommands;
        }
    }
}